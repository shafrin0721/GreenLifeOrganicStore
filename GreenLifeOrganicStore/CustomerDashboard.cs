using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GreenLifeOrganicStore.CartForm;

namespace GreenLifeOrganicStore
{
    public partial class CustomerDashboard : Form
    {

        private string connectionString =
            @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";

        private int customerId;
        private string customerName;

        private List<CartForm.CartItem> cartItems = new List<CartForm.CartItem>();


        public CustomerDashboard(int customerId, string customerName)
        {
            InitializeComponent();

            this.customerId = customerId;
            this.customerName = customerName;
            this.cartItems = new List<CartForm.CartItem>(); // empty cart at login

            lblWelcome.Text = "Welcome, " + customerName;

            LoadProducts();
        }

        public CustomerDashboard(int customerId, string customerName, List<CartForm.CartItem> cartItems)
        {
            InitializeComponent();

            this.customerId = customerId;
            this.customerName = customerName;
            this.cartItems = cartItems ?? new List<CartForm.CartItem>();

            lblWelcome.Text = "Welcome, " + customerName;

            LoadProducts();
        }





        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, Name, Category, Price, Stock, Discount FROM Products " +
                                   "WHERE Name LIKE @s OR Category LIKE @s";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@s", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, Name, Category, Price, Stock, Discount FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            string name = dgvProducts.SelectedRows[0].Cells["Name"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells["Price"].Value);
            int quantity = (int)nudQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            // Add or update in cart
            CartForm.CartItem existingItem = cartItems.FirstOrDefault(x => x.ProductID == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cartItems.Add(new CartForm.CartItem
                {
                    ProductID = productId,
                    Name = name,
                    Price = price,
                    Quantity = quantity
                });
            }


            // Open Cart Form
            CartForm cartForm = new CartForm(customerId, cartItems);
            cartForm.ShowDialog();
        }




        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile profileForm = new CustomerProfile(customerId);
            profileForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().Replace("'", "''"); // escape quotes

            if (dgvProducts.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                if (string.IsNullOrEmpty(filterText))
                {
                    dv.RowFilter = ""; // show all rows
                }
                else
                {
                    dv.RowFilter = $"Name LIKE '%{filterText}%' OR Category LIKE '%{filterText}%'";
                }
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                decimal price = Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells["Price"].Value);
                int quantity = (int)nudQuantity.Value;
                decimal total = price * quantity;

                lblTotalPrice.Text = "Total: " + total.ToString("C"); // C for currency
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            nudQuantity_ValueChanged(sender, e); // Recalculate total for the newly selected product
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
    }
}

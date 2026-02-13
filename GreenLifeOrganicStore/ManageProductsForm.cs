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

namespace GreenLifeOrganicStore
{
    public partial class ManageProductsForm : Form
    {

        private string connectionString = @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;";

        public ManageProductsForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, Name, Category, Price, Stock, Supplier, Discount FROM Products";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Product clicked");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Product clicked");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Product clicked");
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
                decimal price = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Price"].Value);
                decimal discount = Convert.ToDecimal(txtDiscount.Text); // textbox for %

                decimal finalPrice = price - (price * discount / 100);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Products SET Discount=@Discount, FinalPrice=@FinalPrice WHERE ProductID=@ProductID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Discount", discount);
                    cmd.Parameters.AddWithValue("@FinalPrice", finalPrice);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Discount Applied Successfully!");
                LoadProducts();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

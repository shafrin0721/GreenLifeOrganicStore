using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GreenLifeOrganicStore
{
    public partial class CartForm : Form
    {
        private string connectionString =
        @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";

        private int customerId;
        private List<CartItem> cartItems;

        public CartForm(int customerId, List<CartItem> cartItems)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.cartItems = cartItems;

            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ProductID", "Product ID");
            dgvCart.Columns.Add("Name", "Name");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("Total", "Total");

            LoadCart();
        }
        private void LoadCart()
        {
            dgvCart.Rows.Clear();
            decimal grandTotal = 0;

            foreach (var item in cartItems)
            {
                decimal total = item.TotalPrice;
                dgvCart.Rows.Add(item.ProductID, item.Name, item.Price, item.Quantity, total);
                grandTotal += total;
            }

            lblGrandTotal.Text = "Total: " + grandTotal.ToString("C");
        }

        public class CartItem
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice => Price * Quantity;
        }

        // Remove selected item

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                int index = dgvCart.SelectedRows[0].Index;
                cartItems.RemoveAt(index);
                LoadCart();
            }
        }

        // Checkout: place order
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert Order
                    string insertOrder = "INSERT INTO Orders (CustomerID, TotalAmount, Status, OrderDate) " +
                                         "VALUES (@c, @total, @status, @date); SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdOrder = new SqlCommand(insertOrder, conn);
                    decimal grandTotal = cartItems.Sum(x => x.Price * x.Quantity);

                    cmdOrder.Parameters.AddWithValue("@c", customerId);
                    cmdOrder.Parameters.AddWithValue("@total", grandTotal);
                    cmdOrder.Parameters.AddWithValue("@status", "Pending");
                    cmdOrder.Parameters.AddWithValue("@date", DateTime.Now);

                    int orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());

                    // Insert Order Items
                    foreach (var item in cartItems)
                    {
                        string insertItem = "INSERT INTO OrderItems (OrderID, ProductID, Quantity, Price) " +
                                            "VALUES (@o, @p, @q, @pr)";

                        SqlCommand cmdItem = new SqlCommand(insertItem, conn);
                        cmdItem.Parameters.AddWithValue("@o", orderId);
                        cmdItem.Parameters.AddWithValue("@p", item.ProductID);
                        cmdItem.Parameters.AddWithValue("@q", item.Quantity);
                        cmdItem.Parameters.AddWithValue("@pr", item.Price);
                        cmdItem.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order placed successfully!");

                // Clear cart and close form
                cartItems.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}


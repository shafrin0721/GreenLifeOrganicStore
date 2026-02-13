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
    public partial class TrackOrdersForm : Form
    {
        private string connectionString =
            @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";

        private int customerId;

        public TrackOrdersForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadOrders();
            
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT OrderID, OrderDate, PaymentMethod, TotalAmount, Status
                                     FROM Orders
                                     WHERE CustomerID = @cid
                                     ORDER BY OrderDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cid", customerId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }


        private void TrackOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0) return;

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);
            LoadOrderItems(orderId); // <-- this is the method you define below
        }

        private void LoadOrderItems(int orderId)
        {
            dgvOrderItems.Rows.Clear(); // Clear previous items

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT p.Name, oi.Quantity, oi.Price, (oi.Quantity * oi.Price) AS Total
                FROM OrderItems oi
                INNER JOIN Products p ON oi.ProductID = p.ProductID
                WHERE oi.OrderID = @orderId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderId", orderId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvOrderItems.Rows.Add(
                            reader["Name"].ToString(),
                            Convert.ToInt32(reader["Quantity"]),
                            Convert.ToDecimal(reader["Price"]).ToString("C"),
                            Convert.ToDecimal(reader["Total"]).ToString("C")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadOrders();  // Reload the orders from DB
            dgvOrderItems.Rows.Clear(); // Clear the order items grid
        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }      
    }
}

    

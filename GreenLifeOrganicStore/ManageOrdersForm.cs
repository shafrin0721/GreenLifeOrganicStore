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
    public partial class ManageOrdersForm : Form
    {

        private string connectionString = @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;";

        public ManageOrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT OrderID, CustomerID, TotalAmount, Status, PaymentMethod, OrderDate FROM Orders";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void ManageOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Order Status clicked");
        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Order Items clicked");
        }
    }
}

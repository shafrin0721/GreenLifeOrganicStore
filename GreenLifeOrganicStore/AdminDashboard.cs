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
    public partial class AdminDashboard : Form
    {

        private string connectionString = @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";
      
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void CheckLowStock()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Stock FROM Products WHERE Stock < 10";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("⚠ Some products are low in stock! Please restock.");
                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm productsForm = new ManageProductsForm();
            productsForm.ShowDialog();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomersForm customersForm = new ManageCustomersForm();
            customersForm.ShowDialog();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            ManageOrdersForm ordersForm = new ManageOrdersForm();
            ordersForm.ShowDialog();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Load dashboard metrics (Total Sales, Products in stock, Active Orders)
            lblTotalSales.Text = "Total Sales: $0";
            lblProductsInStock.Text = "Products in Stock: 0";
            lblActiveOrders.Text = "Active Orders: 0";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            CheckLowStock();
        }
    }
}

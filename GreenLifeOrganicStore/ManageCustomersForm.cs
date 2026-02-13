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
    public partial class ManageCustomersForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;";

        public ManageCustomersForm()
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
                    string query = "SELECT CustomerID, Name, Email, Phone, Address FROM Customers";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Customer clicked");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Customer clicked");
        }
    
    }
}

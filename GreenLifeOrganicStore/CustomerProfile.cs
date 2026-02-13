using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GreenLifeOrganicStore
{
    public partial class CustomerProfile : Form
    {
        private string connectionString =
            @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";

        private int customerId;

        public CustomerProfile(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadCustomerDetails();
        }

        private void LoadCustomerDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Name, Email, Phone FROM Customers WHERE CustomerID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", customerId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPhone.Text = reader["Phone"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Name and Email cannot be empty.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Customers 
                                     SET Name=@n, Email=@e, Phone=@p 
                                     WHERE CustomerID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", customerId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile Updated Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

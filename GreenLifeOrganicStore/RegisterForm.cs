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
    public partial class RegisterForm : Form
    {
        private string connectionString =
            @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if email already exists
                    string checkQuery = "SELECT COUNT(*) FROM Customers WHERE Email=@e";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Email already registered.");
                        return;
                    }

                    // Insert new customer
                    string insertQuery = "INSERT INTO Customers (Name, Email, Password) VALUES (@n, @e, @p)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                    int rows = insertCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        LoginForm login = new LoginForm();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
            txtConfirm.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}

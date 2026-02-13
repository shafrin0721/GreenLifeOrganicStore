using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace GreenLifeOrganicStore
{
        public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Email and Password.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (cmbRole.SelectedItem.ToString() == "Admin")
                    {
                        string query = "SELECT COUNT(*) FROM Admins WHERE Username=@u AND Password=@p";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@u", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Admin Login Successful!");
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin Credentials!");
                        }
                    }
                    else  // CUSTOMER LOGIN
                    {
                        string query = "SELECT CustomerID, Name FROM Customers WHERE Email=@e AND Password=@p";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int customerId = Convert.ToInt32(reader["CustomerID"]);
                            string customerName = reader["Name"].ToString();

                            MessageBox.Show("Customer Login Successful!");

                            CustomerDashboard dashboard = new CustomerDashboard(customerId, customerName);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Customer Credentials!");
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace GreenLifeOrganicStore
{
    public partial class ReportsForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;";


        public ReportsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generate report clicked");
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {

        }


private void PrintPageHandler(object sender, PrintPageEventArgs e)
    {
        int y = 100;
        Font font = new Font("Arial", 12);

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string line = $"OrderID: {reader["OrderID"]} | " +
                              $"Customer: {reader["CustomerID"]} | " +
                              $"Total: {reader["TotalAmount"]} | " +
                              $"Status: {reader["Status"]}";

                e.Graphics.DrawString(line, font, Brushes.Black, 50, y);
                y += 30;
            }
        }
    }
        PrintDocument pd = new PrintDocument();


        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            pd.PrintPage += new PrintPageEventHandler(this.PrintPageHandler);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore
{

    public partial class QuickActions : Form
    {

        private string connectionString =
            @"Data Source=DESKTOP-RDRJ8S0\SQLEXPRESS;Initial Catalog=GreenLifeDB;Integrated Security=True;TrustServerCertificate=True;";


        private int customerId;
        private string customerName;

        // Cart stored in memory
        private List<CartForm.CartItem> cartItems = new List<CartForm.CartItem>();


        public QuickActions() 
        {
            InitializeComponent();
            
        }

        public QuickActions(int customerId, string customerName) : this()
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (customerId == 0)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            // Pass the cartItems from this form
            CustomerDashboard dashboard = new CustomerDashboard(customerId, customerName, cartItems);
            dashboard.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (customerId == 0)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            CustomerProfile profile = new CustomerProfile(customerId);
            profile.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (customerId == 0)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            TrackOrdersForm trackOrders = new TrackOrdersForm(customerId);
            trackOrders.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (customerId == 0)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            CartForm cart = new CartForm(customerId, cartItems);
            cart.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (customerId == 0)
            {
                MessageBox.Show("Please login first.");
                return;
            }

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            CheckoutForm checkout = new CheckoutForm(customerId, cartItems);
            checkout.ShowDialog();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        // fixed username and password
        private Cashier cashier = new Cashier("Clarisa Castro", "Finance", "cashier101", "password123");

        public frmLoginAccount()
        {
            InitializeComponent();
        }

        // LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both username and password fields.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in the username field.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in the password field.");
                return;
            }

            // Validate the username and password
            if (cashier.ValidateLogin(username, password))
            {
                MessageBox.Show("Welcome " + cashier.GetFullName() + " of " + cashier.GetDepartment());

                frmPurchaseDiscountedItem fdi = new frmPurchaseDiscountedItem();
                fdi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // USERNAME
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // PASSWORD
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

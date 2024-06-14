using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private double totalAmount;
        private DiscountedItem DI;  

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // COMPUTE
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if textBoxes are filled out
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get details from the textBoxes and convert them to double and int
                string item = textBox1.Text;
                double price = Convert.ToDouble(textBox3.Text);
                double discount = Convert.ToDouble(textBox2.Text);
                int quantity = Convert.ToInt32(textBox4.Text);

                // Call out the discounted item object
                DI = new DiscountedItem(item, price, quantity, discount);
                totalAmount = DI.getTotalPrice();
                label6.Text = totalAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // PAYMENT
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DI == null)
                {
                    MessageBox.Show("Compute the total amount first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double payment = Convert.ToDouble(textBox5.Text);

                if (payment < totalAmount)
                {
                    MessageBox.Show("Insufficient payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DI.setPayment(payment);
                double change = DI.getChange();

                label9.Text = change.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount logout = new frmLoginAccount();
            logout.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shopping
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)
                || string.IsNullOrEmpty(textBox3.Text))
            {
                const string message = "You have to fill the all the required fields.";
                const string caption = "Unsigned Fields";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                const string message = "Your Order has took place! Thank you!";
                const string caption = "Succesfull Order";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "To pay for your order you have fill in your Credit/Debit Card Details and Click on 'Pay Now'. " +
                                    "You have to fill in all of the following fields(Card Number, Name on Card, Expiry Date, CVV)." +
                                    "We accept MasterCard, Visa and America Express." +
                                    "If you close the window the order will not take place. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

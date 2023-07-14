using System.Diagnostics;

namespace Shopping
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Payment();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "Here you can see all of your items in your shopping list. " +
                                    "To confirm your Order and Proceed to Payment click on 'Proceed To Payment'." +
                                    "If your are not sure about the items in your List you can go back, to add or remove items, by clicking 'Back'.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


namespace Shopping
{
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newform = new Order();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text)) { return; }
            listBox1.Items.Add(this.textBox1.Text + ", " + this.textBox2.Text + " $");
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "In order to add items to your shopping list, type the description of the item" +
                                    "at 'Item' filed and then add the price of it in the 'Price' field, and click " +
                                    "'Add to List'. If you want to delete an item from your list, you have to select " +
                                    "it form the list, and click 'Delete From List'." +
                                    "If you are Done adding items to your Shopping List and you want to place the " +
                                    "order, click 'Next'.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
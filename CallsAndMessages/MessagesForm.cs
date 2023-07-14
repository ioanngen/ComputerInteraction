using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallsAndMessages
{
    public partial class MessagesForm : Form
    {
        public MessagesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text.Length < 10)
            {
                MessageBox.Show("Please add a number!");
            }
            else
            {
                MessageBox.Show("Message sent to " + numberTextBox.Text + "!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "Type the number you want your message to be sent on the top textbox. " +
                                   "Type the message you want to be sent bellow. " +
                                   "Press send to send the message, or Cancel if you dont want to send a message. \n" +
                                   "You will be informed if the message is sent. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

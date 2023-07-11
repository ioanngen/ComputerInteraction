using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAssistant
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var newform = new Register();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                const string message = "You have to fill both fields in order to Log In. ";
                const string caption = "Unsigned Fields";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else if(textBox1.Text == "User" && textBox2.Text == "User")
            {
                var newform = new MainMenu();
                newform.Show();
                Hide();
            }
            else
            {
                const string message = "Your Credetials are not match any User. ";
                const string caption = "Wrong Username or Password";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }
    }
}

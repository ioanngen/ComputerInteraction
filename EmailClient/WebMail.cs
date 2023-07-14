using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class WebMail : Form
    {
        public WebMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new SendEmail();
            newform.Show();
        }

        private void accountPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new EmailAccount();
            newform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new SendEmail();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) ||
                string.IsNullOrWhiteSpace(this.textBox2.Text) ||
                string.IsNullOrWhiteSpace(this.textBox3.Text) ||
                string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                const string message = "You have to select an Email first to Reply on it.";
                const string caption = "Reply";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) ||
                string.IsNullOrWhiteSpace(this.textBox2.Text) ||
                string.IsNullOrWhiteSpace(this.textBox3.Text) ||
                string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                const string message = "You have to select an Email first to Forward it.";
                const string caption = "Forward";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help();
        }

        static void Help()
        {
            const string message = "This is a WebMail which you can see your emails, send new email, reply, forward and print" +
                                    "them. At the left you can expant your account to see Inbox, Outbox, Drafts etc. At the" +
                                    "centre column you can see your emails, by category (ex. Inbox) if selected. Then you can" +
                                    "select an email to read it at the right field. You can reply by clicking 'Reply', or forward" +
                                    "it by clicking 'Forward'. " +
                                    "To Send an email click on 'New Mail', or go to File>New Mail, to open a pre existand-email" +
                                    "at the file system of your PC, go to File>Open Mail. To print an email, select it at first" +
                                    "and then go to File>Print. At Edit on the menu bar, you can Undo, Redo, Cut, Copy, Paste and" +
                                    "Delete a Mail or move to Bin by selecting it at first." +
                                    "To open an email at a new window go to View>In New Window. At View Category on menu bar, you" +
                                    "can also go to Account Details.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

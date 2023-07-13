namespace EmailClient
{
    public partial class SendEmail : Form
    {
        public static SendEmail? Current { get; set; }
        public SendEmail()
        {
            InitializeComponent();
            Current = this;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newform = new EmailAccount();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text)
                || string.IsNullOrWhiteSpace(this.textBox3.Text)
                || string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                const string message = "To Send an Email you have to sign field 'To', 'Subject', and 'Message'. ";
                const string caption = "Unsigned Fields";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                const string message = "Email has been Send Succesfully";
                const string caption = "Email Send";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                Close();
            }
        }

        private void viewHelpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            const string message = "Here you can send an email, by typing the receiver email, subject and message." +
                                    "By clicking the 'Account' you open the account settings." +
                                    "To Send a new email go to File>New Mail, to open a daft email at the file system " +
                                    "of your PC, go to File>Open Draft or if you want to save the current mail as a " +
                                    "draft go to File>Save Draft. To print an email go to File>Print. At Edit on the " +
                                    "menu bar, you can Undo, Redo, Cut, Copy and Paste.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
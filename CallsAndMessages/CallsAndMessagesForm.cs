namespace CallsAndMessages
{
    public partial class CallsAndMessagesForm : Form
    {
        public CallsAndMessagesForm()
        {
            InitializeComponent();
        }

        private void CallsButton_Click(object sender, EventArgs e)
        {
            var newform = new CallsForm();
            newform.Show();
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {
            var newform = new MessagesForm();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "Left button is for calls, right button is for messages! ";          
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
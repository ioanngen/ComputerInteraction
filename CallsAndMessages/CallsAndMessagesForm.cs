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
    }
}
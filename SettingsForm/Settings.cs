namespace SettingsForm
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "In Settings you can change various parameters such as the language of the personal assisant and your Location at, " +
                                    "at 'General' tab and your Personal Info(Name, Surname, Email, Username, Password) at 'User' tab." +
                                    "To change the languge of the personal assistan select from the Drop Down List 'Language' your prefered Language." +
                                    "To change the Location select from the Drop Down List 'Location' the city you are right now." +
                                    "You can also change your Name, Surname, Username and Email by typing the new ones at the right files and clicking " +
                                    "'OK' or 'Apply'. To change your password, type it in the 'Password' field, and re-type it below and then click " +
                                    "'OK' or 'Apply'. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
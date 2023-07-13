using EmailClient;
using Forms_Appointments;
using SettingsForm;
using Shopping;
using MusicPlayer;
using Contacts;
using Smart_Home;
using CallsAndMessages;
using Reminders;

namespace PersonalAssistant
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newform = new WebMail();
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newform = new Settings();
            newform.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var newform = new Calendar();
            newform.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var newform = new ShoppingList();
            newform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var newform = new MusicPlayer.MusicPlayerWin();
            newform.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newform = new ContactsForm();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newform = new SmartHome();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new CallsAndMessagesForm();
            newform.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var newform = new RemindersForm();
            newform.Show();
        }
    }
}
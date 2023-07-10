using EmailClient;
using Forms_Appointments;
using SettingsForm;
using Shopping;
using MusicPlayer;
using Contacts;
using System.Windows.Forms;

namespace PersonalAssistant
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            DisplayNews();
        }

        private void DisplayNews()
        {
            List<string> imagePaths = new List<string>()
            {
                "C:\\Users\\spiro\\Desktop\\I.C.E\\Semesters\\(8)Eighth Semester\\Human Computer Interaction\\PA\\ComputerInteraction\\NewsImages\\news1.png",
                "C:\\Users\\spiro\\Desktop\\I.C.E\\Semesters\\(8)Eighth Semester\\Human Computer Interaction\\PA\\ComputerInteraction\\NewsImages\\news2.png",
            };
            foreach (string imagePath in imagePaths)
            {
                Image image = Image.FromFile(imagePath);
                pbNews.Image = image;
                Thread.Sleep(1000);
                pbNews.Refresh();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            var newform = new WebMail();
            newform.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var newform = new Settings();
            newform.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            var newform = new Calendar();
            newform.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            var newform = new ShoppingList();
            newform.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            var newform = new MusicPlayer.MusicPlayerWin();
            newform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newform = new ContactsForm();
            newform.Show();
        }
    }
}
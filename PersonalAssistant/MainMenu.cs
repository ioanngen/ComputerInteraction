using EmailClient;
using Forms_Appointments;
using SettingsForm;
using Shopping;
using MusicPlayer;
using Contacts;
using Smart_Home;
using CallsAndMessages;
using Reminders;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Maps;

namespace PersonalAssistant
{
    public partial class MainMenu : Form
    {
        public int newsIndex = 1;
        public string path = @"C:\Users\spiro\Desktop\I.C.E\Semesters\(8)Eighth Semester\Human Computer Interaction\PA\ComputerInteraction\NewsImages\";
        public List<string> NewsImages
        {
            get
            {
                return new List<string>
                {
                    path+@"news1.png",
                    path+@"news2.png",
                    path+@"news3.png",
                    path+@"news4.png",
                    path+@"news5.png"
                };
            }
        }
        public MainMenu()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var newform = new SmartHome();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new CallsAndMessages.CallsAndMessagesForm();
            newform.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var newform = new RemindersForm();
            newform.Show();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            newsIndex++;
            if (newsIndex > 4)
            {
                pbNews.Image = Image.FromFile(NewsImages[0]);
                newsIndex = 0;
            }
            else
            {
                pbNews.Image = Image.FromFile(NewsImages[newsIndex]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newform = new MapsForm();
            newform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newform = new ProjectManagerMenuForm();
            newform.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
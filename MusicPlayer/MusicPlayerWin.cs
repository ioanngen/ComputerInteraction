namespace MusicPlayer
{
    public partial class MusicPlayerWin : Form
    {
        public MusicPlayerWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Mp3Player mp3Player = new Mp3Player();

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files| *.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "This is a Music Player. To open a music file and play it, click at first on the folder icon, and then you can" +
                                    "click on play button to start playing music. To skip a music file click on the skip button, and to go to the" +
                                    "previous file click on the previous button. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
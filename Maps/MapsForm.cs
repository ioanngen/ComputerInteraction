using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace Maps
{
    public partial class MapsForm : Form
    {
        public int mapsIndex = 0;
        public int directionsIndex = 0;
        public string path = @"C:\Users\spiro\Desktop\I.C.E\Semesters\(8)Eighth Semester\Human Computer Interaction\PA\ComputerInteraction\MapsImages\";
        bool CanChangeLocation = false;
        bool init = true;
        public List<string> MapImages
        {
            get
            {
                return new List<string>
                {
                    path+@"StartingPoint.png",
                    path+@"FirstSetDone.png",
                    path+@"SecondSetDone.png",
                    path+@"ThirdSetDone.png",
                    path+@"Arrived.png"
                };
            }
        }
        public List<string> DirectionImages
        {
            get
            {
                return new List<string>
                {
                    path+@"Directions1.png",
                    path+@"Directions2.png",
                    path+@"Directions3.png",
                    path+@"Directions4.png",
                    path+@"Directions5.png",
                    path+@"Directions6.png",
                    path+@"Directions7.png",
                    path+@"Directions8.png"
                };
            }
        }

        public MapsForm()
        {
            InitializeComponent();
        }

        private void NextPoint_Click(object sender, EventArgs e)
        {
            bool changeMap = false;

            if (directionsIndex < 8)
            {
                DirectionsBox.Image = Image.FromFile(DirectionImages[directionsIndex]);
                directionsIndex++;
            }
            if (directionsIndex % 2 == 0)
            {
                changeMap = true;
            }
            if (mapsIndex > 4 && changeMap)
            {
                MessageBox.Show("Congratulations, you have arrived!", "Destination Reached");
                CanChangeLocation = true;
                Navigate.Enabled = true;
            }
            else if (mapsIndex <= 4 && changeMap)
            {
                MapBox.Image = Image.FromFile(MapImages[mapsIndex]);
                mapsIndex++;
            }

        }

        private void Navigate_Click(object sender, EventArgs e)
        {
            if (LocationTextArea.Text == "")
            {
                MessageBox.Show("Please enter a valid location", "Location Error");
            }
            if (LocationTextArea.Text != "" && init)
            {
                InitializePictureBoxes();
                Navigate.Enabled = false;
                init = false;
            }
            if (directionsIndex != 0 && mapsIndex != 0 && CanChangeLocation)
            {
                MessageBox.Show("Loading directions for the new location", "Recalibrating");
                InitializePictureBoxes();
            }
        }

        public void InitializePictureBoxes()
        {
            MessageBox.Show("Please follow the directions to reach the desired destination", "Location found"); ;
            MapBox.Image = Image.FromFile(MapImages[0]);
            DirectionsBox.Image = Image.FromFile(DirectionImages[0]);
            NextPoint.Enabled = true;
            directionsIndex = 1;
            mapsIndex = 1;
        }
    }
}
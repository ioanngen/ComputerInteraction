namespace Smart_Home
{
    public partial class SmartHome : Form
    {
        static int currentTemp = 25;
        static int airConditionAngle = 30;
        // Maybe another path is necessery here
        string path = @"C:\Users\Shinano\Documents\GitHub\ComputerInteraction\Images\";
        int lamp1flag = 0;
        int lampLivRoom1flag = 0,
            lampLivRoom2flag = 0,
            lampBedroomflag = 0,
            lampBathroom1flag = 0,
            lampBathroom2flag = 0,
            lampKitchenflag = 0,
            lampHullflag = 0;

        public List<string> LampImages
        {
            get
            {
                return new List<string>
                {
                    path+@"Opened_light62x52.png",
                    path+@"Closed_light62x52.png"
                };
            }
        }

        public SmartHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Increase Angle
        private void button4_Click(object sender, EventArgs e)
        {
            airConditionAngle = airConditionAngle + 15;
            if (airConditionAngle > 90)
            {
                airConditionAngle = 90;
            }
            lbAirCondAngle.Text = "Air Conditioner Angle: " + airConditionAngle.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (lamp1flag == 0)
            {
                pictureBoxLamp1.Image = Image.FromFile(LampImages[lamp1flag]);
                lamp1flag = 1;
            }
            else
            {
                pictureBoxLamp1.Image = Image.FromFile(LampImages[lamp1flag]);
                lamp1flag = 0;
            }


        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnLivingRoom1_Click(object sender, EventArgs e)
        {
            if (lampLivRoom1flag == 0)
            {
                picBoxLivRoom1.Image = Image.FromFile(LampImages[lampLivRoom1flag]);
                lampLivRoom1flag = 1;
            }
            else
            {
                picBoxLivRoom1.Image = Image.FromFile(LampImages[lampLivRoom1flag]);
                lampLivRoom1flag = 0;
            }
        }

        private void btnLivingRoom2_Click(object sender, EventArgs e)
        {
            if (lampLivRoom2flag == 0)
            {
                picBoxLivRoom2.Image = Image.FromFile(LampImages[lampLivRoom2flag]);
                lampLivRoom2flag = 1;
            }
            else
            {
                picBoxLivRoom2.Image = Image.FromFile(LampImages[lampLivRoom2flag]);
                lampLivRoom2flag = 0;
            }
        }

        private void btnBedroom_Click(object sender, EventArgs e)
        {
            if (lampBedroomflag == 0)
            {
                picBoxBedroom.Image = Image.FromFile(LampImages[lampBedroomflag]);
                lampBedroomflag = 1;
            }
            else
            {
                picBoxBedroom.Image = Image.FromFile(LampImages[lampBedroomflag]);
                lampBedroomflag = 0;
            }
        }

        private void btnBathroom1_Click(object sender, EventArgs e)
        {
            if (lampBathroom1flag == 0)
            {
                picBathroom1.Image = Image.FromFile(LampImages[lampBathroom1flag]);
                lampBathroom1flag = 1;
            }
            else
            {
                picBathroom1.Image = Image.FromFile(LampImages[lampBathroom1flag]);
                lampBathroom1flag = 0;
            }
        }

        private void btnBathroom2_Click(object sender, EventArgs e)
        {
            if (lampBathroom2flag == 0)
            {
                picBathroom2.Image = Image.FromFile(LampImages[lampBathroom2flag]);
                lampBathroom2flag = 1;
            }
            else
            {
                picBathroom2.Image = Image.FromFile(LampImages[lampBathroom2flag]);
                lampBathroom2flag = 0;
            }
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            if (lampKitchenflag == 0)
            {
                picKitchen.Image = Image.FromFile(LampImages[lampKitchenflag]);
                lampKitchenflag = 1;
            }
            else
            {
                picKitchen.Image = Image.FromFile(LampImages[lampKitchenflag]);
                lampKitchenflag = 0;
            }
        }

        private void btnHull_Click(object sender, EventArgs e)
        {
            if (lampHullflag == 0)
            {
                picHull.Image = Image.FromFile(LampImages[lampHullflag]);
                lampHullflag = 1;
            }
            else
            {
                picHull.Image = Image.FromFile(LampImages[lampHullflag]);
                lampHullflag = 0;
            }
        }

        private void picIncrTemp_Click(object sender, EventArgs e)
        {
            currentTemp++;
            if (currentTemp > 29)
            {
                currentTemp = 30;
            }
            labelTemp.Text = currentTemp.ToString() + "°";

        }

        private void picDecTemp_Click(object sender, EventArgs e)
        {
            currentTemp--;
            if (currentTemp < 26)
            {
                currentTemp = 25;
            }
            labelTemp.Text = currentTemp.ToString() + "°";

        }

        //Decrease Angle
        private void btnSwingDown_Click(object sender, EventArgs e)
        {
            airConditionAngle = airConditionAngle - 15;
            if (airConditionAngle < 0)
            {
                airConditionAngle = 0;
            }
            lbAirCondAngle.Text = "Air Conditioner Angle: " + airConditionAngle.ToString();
        }
    }
}
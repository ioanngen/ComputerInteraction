namespace Smart_Home
{
    partial class SmartHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartHome));
            backroundpicture = new PictureBox();
            pictureBox1 = new PictureBox();
            labelTemp = new Label();
            label2 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            btnSwingUp = new Button();
            btnSwingDown = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton16 = new RadioButton();
            radioButton17 = new RadioButton();
            radioButton18 = new RadioButton();
            label3 = new Label();
            button2 = new Button();
            button7 = new Button();
            label4 = new Label();
            lbAirCondAngle = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            picDecTemp = new PictureBox();
            button14 = new Button();
            lampImagelist = new ImageList(components);
            picIncrTemp = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxLamp1 = new PictureBox();
            btnLivingRoom1 = new Button();
            picBoxLivRoom1 = new PictureBox();
            picBoxLivRoom2 = new PictureBox();
            btnLivingRoom2 = new Button();
            picBoxBedroom = new PictureBox();
            btnBedroom = new Button();
            picBathroom1 = new PictureBox();
            btnBathroom1 = new Button();
            picKitchen = new PictureBox();
            btnKitchen = new Button();
            picHull = new PictureBox();
            btnHull = new Button();
            picBathroom2 = new PictureBox();
            btnBathroom2 = new Button();
            ((System.ComponentModel.ISupportInitialize)backroundpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDecTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIncrTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLamp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLivRoom1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLivRoom2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBedroom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBathroom1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHull).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBathroom2).BeginInit();
            SuspendLayout();
            // 
            // backroundpicture
            // 
            backroundpicture.Image = Properties.Resources.SmartHomeUpViewfinal2;
            backroundpicture.Location = new Point(37, 12);
            backroundpicture.Name = "backroundpicture";
            backroundpicture.Size = new Size(776, 457);
            backroundpicture.SizeMode = PictureBoxSizeMode.StretchImage;
            backroundpicture.TabIndex = 0;
            backroundpicture.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hoop;
            pictureBox1.Location = new Point(849, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemp.Location = new Point(902, 63);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(101, 55);
            labelTemp.TabIndex = 2;
            labelTemp.Text = "25°";
            labelTemp.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(902, 118);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 3;
            label2.Text = "Celcius";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(991, 336);
            button3.Name = "button3";
            button3.Size = new Size(66, 38);
            button3.TabIndex = 6;
            button3.Text = "ON/OFF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Heat Mode", "Cool Mode", "Ionizing Mode" });
            comboBox1.Location = new Point(837, 380);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 22);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Air Conditioner Mode";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(910, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 9;
            button1.Text = "Set Timer";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSwingUp
            // 
            btnSwingUp.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSwingUp.Location = new Point(837, 409);
            btnSwingUp.Name = "btnSwingUp";
            btnSwingUp.Size = new Size(101, 40);
            btnSwingUp.TabIndex = 10;
            btnSwingUp.Text = "Swing Up";
            btnSwingUp.UseVisualStyleBackColor = true;
            btnSwingUp.Click += button4_Click;
            // 
            // btnSwingDown
            // 
            btnSwingDown.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSwingDown.Location = new Point(955, 409);
            btnSwingDown.Name = "btnSwingDown";
            btnSwingDown.Size = new Size(102, 40);
            btnSwingDown.TabIndex = 11;
            btnSwingDown.Text = "Swing Down";
            btnSwingDown.UseVisualStyleBackColor = true;
            btnSwingDown.Click += btnSwingDown_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(837, 336);
            button6.Name = "button6";
            button6.Size = new Size(66, 38);
            button6.TabIndex = 12;
            button6.Text = "Auto Swing";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton9);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(837, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 112);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Room AirConditioner";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(17, 16);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(84, 18);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "All Rooms";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(17, 92);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(92, 18);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "Bathroom 2";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(124, 92);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(47, 18);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "Hull";
            radioButton7.TextAlign = ContentAlignment.MiddleCenter;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(17, 73);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(92, 18);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "Bathroom 1";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(124, 54);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(69, 18);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Kitchen";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(124, 35);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(69, 18);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Garage";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 54);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(107, 18);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Living Room 2";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(124, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 18);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bedroom";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 18);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Living Room 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton10);
            groupBox2.Controls.Add(radioButton11);
            groupBox2.Controls.Add(radioButton12);
            groupBox2.Controls.Add(radioButton13);
            groupBox2.Controls.Add(radioButton14);
            groupBox2.Controls.Add(radioButton15);
            groupBox2.Controls.Add(radioButton16);
            groupBox2.Controls.Add(radioButton17);
            groupBox2.Controls.Add(radioButton18);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(671, 480);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(131, 248);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose Camera:";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(6, 22);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(84, 18);
            radioButton10.TabIndex = 8;
            radioButton10.TabStop = true;
            radioButton10.Text = "All Rooms";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(6, 122);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(92, 18);
            radioButton11.TabIndex = 7;
            radioButton11.TabStop = true;
            radioButton11.Text = "Bathroom 2";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(6, 222);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(47, 18);
            radioButton12.TabIndex = 6;
            radioButton12.TabStop = true;
            radioButton12.Text = "Hull";
            radioButton12.TextAlign = ContentAlignment.MiddleCenter;
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(6, 97);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(92, 18);
            radioButton13.TabIndex = 5;
            radioButton13.TabStop = true;
            radioButton13.Text = "Bathroom 1";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Location = new Point(6, 172);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(69, 18);
            radioButton14.TabIndex = 4;
            radioButton14.TabStop = true;
            radioButton14.Text = "Kitchen";
            radioButton14.TextAlign = ContentAlignment.MiddleCenter;
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(6, 147);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(69, 18);
            radioButton15.TabIndex = 3;
            radioButton15.TabStop = true;
            radioButton15.Text = "Garage";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            radioButton16.AutoSize = true;
            radioButton16.Location = new Point(6, 72);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(107, 18);
            radioButton16.TabIndex = 2;
            radioButton16.TabStop = true;
            radioButton16.Text = "Living Room 2";
            radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            radioButton17.AutoSize = true;
            radioButton17.Location = new Point(6, 197);
            radioButton17.Name = "radioButton17";
            radioButton17.Size = new Size(79, 18);
            radioButton17.TabIndex = 1;
            radioButton17.TabStop = true;
            radioButton17.Text = "Bedroom";
            radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            radioButton18.AutoSize = true;
            radioButton18.Location = new Point(6, 47);
            radioButton18.Name = "radioButton18";
            radioButton18.Size = new Size(107, 18);
            radioButton18.TabIndex = 0;
            radioButton18.TabStop = true;
            radioButton18.Text = "Living Room 1";
            radioButton18.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 480);
            label3.Name = "label3";
            label3.Size = new Size(187, 18);
            label3.TabIndex = 17;
            label3.Text = "Water Heater Control: ";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 480);
            button2.Name = "button2";
            button2.Size = new Size(56, 37);
            button2.TabIndex = 18;
            button2.Text = "On";
            button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(367, 480);
            button7.Name = "button7";
            button7.Size = new Size(56, 37);
            button7.TabIndex = 19;
            button7.Text = "Off";
            button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 502);
            label4.Name = "label4";
            label4.Size = new Size(243, 14);
            label4.TabIndex = 20;
            label4.Text = "Last Time on power: 10/07/2023 00:00:00";
            label4.Click += label4_Click;
            // 
            // lbAirCondAngle
            // 
            lbAirCondAngle.AutoSize = true;
            lbAirCondAngle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAirCondAngle.Location = new Point(843, 451);
            lbAirCondAngle.Name = "lbAirCondAngle";
            lbAirCondAngle.Size = new Size(207, 18);
            lbAirCondAngle.TabIndex = 29;
            lbAirCondAngle.Text = "Air Conditioner Angle: 30";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(628, 38);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 39;
            label5.Text = "Bedroom";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(461, 297);
            label6.Name = "label6";
            label6.Size = new Size(51, 14);
            label6.TabIndex = 40;
            label6.Text = "Kitchen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(658, 297);
            label7.Name = "label7";
            label7.Size = new Size(38, 18);
            label7.TabIndex = 41;
            label7.Text = "Hull";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(729, 297);
            label8.Name = "label8";
            label8.Size = new Size(74, 14);
            label8.TabIndex = 42;
            label8.Text = "Bathroom 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(372, 364);
            label9.Name = "label9";
            label9.Size = new Size(74, 14);
            label9.TabIndex = 43;
            label9.Text = "Bathroom 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(156, 253);
            label10.Name = "label10";
            label10.Size = new Size(68, 18);
            label10.TabIndex = 44;
            label10.Text = "Garage";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(122, 82);
            label11.Name = "label11";
            label11.Size = new Size(119, 18);
            label11.TabIndex = 45;
            label11.Text = "Living Room 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(367, 82);
            label12.Name = "label12";
            label12.Size = new Size(119, 18);
            label12.TabIndex = 46;
            label12.Text = "Living Room 2";
            // 
            // picDecTemp
            // 
            picDecTemp.Image = Properties.Resources.minus;
            picDecTemp.Location = new Point(829, 177);
            picDecTemp.Name = "picDecTemp";
            picDecTemp.Size = new Size(40, 40);
            picDecTemp.SizeMode = PictureBoxSizeMode.StretchImage;
            picDecTemp.TabIndex = 48;
            picDecTemp.TabStop = false;
            picDecTemp.Click += picDecTemp_Click;
            // 
            // button14
            // 
            button14.Location = new Point(73, 390);
            button14.Name = "button14";
            button14.Size = new Size(65, 23);
            button14.TabIndex = 55;
            button14.Text = "On/Off";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // lampImagelist
            // 
            lampImagelist.ColorDepth = ColorDepth.Depth24Bit;
            lampImagelist.ImageStream = (ImageListStreamer)resources.GetObject("lampImagelist.ImageStream");
            lampImagelist.TransparentColor = Color.Transparent;
            lampImagelist.Images.SetKeyName(0, "Closed_light62x52.png");
            lampImagelist.Images.SetKeyName(1, "Opened_light62x52.png");
            // 
            // picIncrTemp
            // 
            picIncrTemp.Image = Properties.Resources.plus;
            picIncrTemp.Location = new Point(1028, 177);
            picIncrTemp.Name = "picIncrTemp";
            picIncrTemp.Size = new Size(40, 40);
            picIncrTemp.SizeMode = PictureBoxSizeMode.StretchImage;
            picIncrTemp.TabIndex = 58;
            picIncrTemp.TabStop = false;
            picIncrTemp.Click += picIncrTemp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Random_House_Picture;
            pictureBox2.Location = new Point(816, 477);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 256);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxLamp1
            // 
            pictureBoxLamp1.Image = Properties.Resources.Closed_light62x52;
            pictureBoxLamp1.Location = new Point(80, 325);
            pictureBoxLamp1.Name = "pictureBoxLamp1";
            pictureBoxLamp1.Size = new Size(52, 62);
            pictureBoxLamp1.TabIndex = 59;
            pictureBoxLamp1.TabStop = false;
            pictureBoxLamp1.Click += pictureBox3_Click;
            // 
            // btnLivingRoom1
            // 
            btnLivingRoom1.Location = new Point(139, 194);
            btnLivingRoom1.Name = "btnLivingRoom1";
            btnLivingRoom1.Size = new Size(65, 23);
            btnLivingRoom1.TabIndex = 60;
            btnLivingRoom1.Text = "On/Off";
            btnLivingRoom1.UseVisualStyleBackColor = true;
            btnLivingRoom1.Click += btnLivingRoom1_Click;
            // 
            // picBoxLivRoom1
            // 
            picBoxLivRoom1.Image = Properties.Resources.Closed_light62x52;
            picBoxLivRoom1.Location = new Point(146, 126);
            picBoxLivRoom1.Name = "picBoxLivRoom1";
            picBoxLivRoom1.Size = new Size(52, 62);
            picBoxLivRoom1.TabIndex = 61;
            picBoxLivRoom1.TabStop = false;
            // 
            // picBoxLivRoom2
            // 
            picBoxLivRoom2.Image = Properties.Resources.Closed_light62x52;
            picBoxLivRoom2.Location = new Point(390, 150);
            picBoxLivRoom2.Name = "picBoxLivRoom2";
            picBoxLivRoom2.Size = new Size(52, 62);
            picBoxLivRoom2.TabIndex = 63;
            picBoxLivRoom2.TabStop = false;
            // 
            // btnLivingRoom2
            // 
            btnLivingRoom2.Location = new Point(383, 218);
            btnLivingRoom2.Name = "btnLivingRoom2";
            btnLivingRoom2.Size = new Size(65, 23);
            btnLivingRoom2.TabIndex = 62;
            btnLivingRoom2.Text = "On/Off";
            btnLivingRoom2.UseVisualStyleBackColor = true;
            btnLivingRoom2.Click += btnLivingRoom2_Click;
            // 
            // picBoxBedroom
            // 
            picBoxBedroom.Image = Properties.Resources.Closed_light62x52;
            picBoxBedroom.Location = new Point(578, 136);
            picBoxBedroom.Name = "picBoxBedroom";
            picBoxBedroom.Size = new Size(52, 62);
            picBoxBedroom.TabIndex = 65;
            picBoxBedroom.TabStop = false;
            // 
            // btnBedroom
            // 
            btnBedroom.Location = new Point(571, 204);
            btnBedroom.Name = "btnBedroom";
            btnBedroom.Size = new Size(65, 23);
            btnBedroom.TabIndex = 64;
            btnBedroom.Text = "On/Off";
            btnBedroom.UseVisualStyleBackColor = true;
            btnBedroom.Click += btnBedroom_Click;
            // 
            // picBathroom1
            // 
            picBathroom1.Image = Properties.Resources.Closed_light62x52;
            picBathroom1.Location = new Point(319, 366);
            picBathroom1.Name = "picBathroom1";
            picBathroom1.Size = new Size(52, 62);
            picBathroom1.TabIndex = 67;
            picBathroom1.TabStop = false;
            // 
            // btnBathroom1
            // 
            btnBathroom1.Location = new Point(311, 430);
            btnBathroom1.Name = "btnBathroom1";
            btnBathroom1.Size = new Size(65, 23);
            btnBathroom1.TabIndex = 66;
            btnBathroom1.Text = "On/Off";
            btnBathroom1.UseVisualStyleBackColor = true;
            btnBathroom1.Click += btnBathroom1_Click;
            // 
            // picKitchen
            // 
            picKitchen.Image = Properties.Resources.Closed_light62x52;
            picKitchen.Location = new Point(461, 313);
            picKitchen.Name = "picKitchen";
            picKitchen.Size = new Size(52, 62);
            picKitchen.TabIndex = 69;
            picKitchen.TabStop = false;
            // 
            // btnKitchen
            // 
            btnKitchen.Location = new Point(456, 378);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Size = new Size(65, 23);
            btnKitchen.TabIndex = 68;
            btnKitchen.Text = "On/Off";
            btnKitchen.UseVisualStyleBackColor = true;
            btnKitchen.Click += btnKitchen_Click;
            // 
            // picHull
            // 
            picHull.Image = Properties.Resources.Closed_light62x52;
            picHull.Location = new Point(649, 343);
            picHull.Name = "picHull";
            picHull.Size = new Size(52, 62);
            picHull.TabIndex = 71;
            picHull.TabStop = false;
            // 
            // btnHull
            // 
            btnHull.Location = new Point(642, 411);
            btnHull.Name = "btnHull";
            btnHull.Size = new Size(65, 23);
            btnHull.TabIndex = 70;
            btnHull.Text = "On/Off";
            btnHull.UseVisualStyleBackColor = true;
            btnHull.Click += btnHull_Click;
            // 
            // picBathroom2
            // 
            picBathroom2.Image = Properties.Resources.Closed_light62x52;
            picBathroom2.Location = new Point(762, 330);
            picBathroom2.Name = "picBathroom2";
            picBathroom2.Size = new Size(40, 51);
            picBathroom2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBathroom2.TabIndex = 73;
            picBathroom2.TabStop = false;
            // 
            // btnBathroom2
            // 
            btnBathroom2.Location = new Point(738, 385);
            btnBathroom2.Name = "btnBathroom2";
            btnBathroom2.Size = new Size(65, 23);
            btnBathroom2.TabIndex = 72;
            btnBathroom2.Text = "On/Off";
            btnBathroom2.UseVisualStyleBackColor = true;
            btnBathroom2.Click += btnBathroom2_Click;
            // 
            // SmartHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 740);
            Controls.Add(picBathroom2);
            Controls.Add(btnBathroom2);
            Controls.Add(picHull);
            Controls.Add(btnHull);
            Controls.Add(picKitchen);
            Controls.Add(btnKitchen);
            Controls.Add(picBathroom1);
            Controls.Add(btnBathroom1);
            Controls.Add(picBoxBedroom);
            Controls.Add(btnBedroom);
            Controls.Add(picBoxLivRoom2);
            Controls.Add(btnLivingRoom2);
            Controls.Add(picBoxLivRoom1);
            Controls.Add(btnLivingRoom1);
            Controls.Add(pictureBoxLamp1);
            Controls.Add(picIncrTemp);
            Controls.Add(button14);
            Controls.Add(picDecTemp);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbAirCondAngle);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(btnSwingDown);
            Controls.Add(btnSwingUp);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(labelTemp);
            Controls.Add(pictureBox1);
            Controls.Add(backroundpicture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SmartHome";
            Text = "Smart Home Control";
            ((System.ComponentModel.ISupportInitialize)backroundpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDecTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIncrTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLamp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLivRoom1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLivRoom2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBedroom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBathroom1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHull).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBathroom2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backroundpicture;
        private PictureBox pictureBox1;
        private Label labelTemp;
        private Label label2;
        private Button button3;
        private ComboBox comboBox1;
        private Button button1;
        private Button btnSwingUp;
        private Button btnSwingDown;
        private Button button6;
        private GroupBox groupBox1;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private Label label3;
        private Button button2;
        private Button button7;
        private Label label4;
        private Label lbAirCondAngle;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox picDecTemp;
        private Button button14;
        private Button button16;
        private ImageList lampImagelist;
        private PictureBox picIncrTemp;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLamp1;
        private Button btnLivingRoom1;
        private PictureBox picBoxLivRoom1;
        private PictureBox picBoxLivRoom2;
        private Button btnLivingRoom2;
        private PictureBox picBoxBedroom;
        private Button btnBedroom;
        private PictureBox picBathroom1;
        private Button btnBathroom1;
        private PictureBox picKitchen;
        private Button btnKitchen;
        private PictureBox picHull;
        private Button btnHull;
        private PictureBox picBathroom2;
        private Button btnBathroom2;
    }
}
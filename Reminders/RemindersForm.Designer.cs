namespace Reminders
{
    partial class RemindersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindersForm));
            daycontainer = new FlowLayoutPanel();
            buttonPrevious = new Button();
            buttonNext = new Button();
            labelMonday = new Label();
            labelTuesday = new Label();
            labelWednesday = new Label();
            labelThursday = new Label();
            labelFriday = new Label();
            labelSaturday = new Label();
            labelSunday = new Label();
            LBDATE = new Label();
            picBoxAlarm = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxAlarm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(12, 107);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1240, 520);
            daycontainer.TabIndex = 0;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(1096, 631);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(75, 23);
            buttonPrevious.TabIndex = 1;
            buttonPrevious.Text = "Previous";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(1177, 631);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelMonday
            // 
            labelMonday.AutoSize = true;
            labelMonday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMonday.Location = new Point(59, 84);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(70, 18);
            labelMonday.TabIndex = 3;
            labelMonday.Text = "Monday";
            // 
            // labelTuesday
            // 
            labelTuesday.AutoSize = true;
            labelTuesday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTuesday.Location = new Point(234, 84);
            labelTuesday.Name = "labelTuesday";
            labelTuesday.Size = new Size(76, 18);
            labelTuesday.TabIndex = 10;
            labelTuesday.Text = "Tuesday";
            // 
            // labelWednesday
            // 
            labelWednesday.AutoSize = true;
            labelWednesday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWednesday.Location = new Point(399, 84);
            labelWednesday.Name = "labelWednesday";
            labelWednesday.Size = new Size(101, 18);
            labelWednesday.TabIndex = 11;
            labelWednesday.Text = "Wednesday";
            // 
            // labelThursday
            // 
            labelThursday.AutoSize = true;
            labelThursday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelThursday.Location = new Point(587, 84);
            labelThursday.Name = "labelThursday";
            labelThursday.Size = new Size(83, 18);
            labelThursday.TabIndex = 12;
            labelThursday.Text = "Thursday";
            // 
            // labelFriday
            // 
            labelFriday.AutoSize = true;
            labelFriday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFriday.Location = new Point(771, 84);
            labelFriday.Name = "labelFriday";
            labelFriday.Size = new Size(58, 18);
            labelFriday.TabIndex = 13;
            labelFriday.Text = "Friday";
            // 
            // labelSaturday
            // 
            labelSaturday.AutoSize = true;
            labelSaturday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSaturday.Location = new Point(943, 84);
            labelSaturday.Name = "labelSaturday";
            labelSaturday.Size = new Size(81, 18);
            labelSaturday.TabIndex = 14;
            labelSaturday.Text = "Saturday";
            // 
            // labelSunday
            // 
            labelSunday.AutoSize = true;
            labelSunday.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSunday.Location = new Point(1123, 84);
            labelSunday.Name = "labelSunday";
            labelSunday.Size = new Size(68, 18);
            labelSunday.TabIndex = 15;
            labelSunday.Text = "Sunday";
            // 
            // LBDATE
            // 
            LBDATE.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LBDATE.Location = new Point(399, 33);
            LBDATE.Name = "LBDATE";
            LBDATE.Size = new Size(459, 39);
            LBDATE.TabIndex = 16;
            LBDATE.Text = "MONTH YEAR";
            LBDATE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBoxAlarm
            // 
            picBoxAlarm.Image = Properties.Resources.alarm_clock;
            picBoxAlarm.Location = new Point(1188, 9);
            picBoxAlarm.Name = "picBoxAlarm";
            picBoxAlarm.Size = new Size(64, 64);
            picBoxAlarm.TabIndex = 17;
            picBoxAlarm.TabStop = false;
            picBoxAlarm.Click += picBoxAlarm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.plusBlackWhite;
            pictureBox1.Location = new Point(683, 637);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Add Reminder");
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.list_text;
            pictureBox2.Location = new Point(613, 631);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            toolTip1.SetToolTip(pictureBox2, "View the List of Reminders");
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(12, 655);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 20;
            button6.UseVisualStyleBackColor = true;
            // 
            // RemindersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 707);
            Controls.Add(button6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(picBoxAlarm);
            Controls.Add(LBDATE);
            Controls.Add(labelSunday);
            Controls.Add(labelSaturday);
            Controls.Add(labelFriday);
            Controls.Add(labelThursday);
            Controls.Add(labelWednesday);
            Controls.Add(labelTuesday);
            Controls.Add(labelMonday);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(daycontainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RemindersForm";
            Text = "Reminders and Alarms";
            Load += RemindersForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxAlarm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label labelMonday;
        private Label labelTuesday;
        private Label labelWednesday;
        private Label labelThursday;
        private Label labelFriday;
        private Label labelSaturday;
        private Label labelSunday;
        private Label LBDATE;
        private PictureBox picBoxAlarm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
        private Button button6;
    }
}
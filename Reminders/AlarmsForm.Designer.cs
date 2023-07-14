namespace Reminders
{
    partial class AlarmsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmsForm));
            picBoxReminders = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            btnStart = new Button();
            btnStop = new Button();
            lbAlarmTitle = new Label();
            lbAlarmStatus = new Label();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxReminders).BeginInit();
            SuspendLayout();
            // 
            // picBoxReminders
            // 
            picBoxReminders.Image = Properties.Resources.bell;
            picBoxReminders.Location = new Point(12, 12);
            picBoxReminders.Name = "picBoxReminders";
            picBoxReminders.Size = new Size(64, 67);
            picBoxReminders.TabIndex = 0;
            picBoxReminders.TabStop = false;
            picBoxReminders.Click += picBoxReminders_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(60, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 1;
            toolTip1.SetToolTip(dateTimePicker1, "Set time for Alarm");
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(141, 140);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            toolTip1.SetToolTip(btnStart, "Start the Alarm");
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(60, 140);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            toolTip1.SetToolTip(btnStop, "Stop the Alarm");
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lbAlarmTitle
            // 
            lbAlarmTitle.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbAlarmTitle.Location = new Point(82, 33);
            lbAlarmTitle.Name = "lbAlarmTitle";
            lbAlarmTitle.Size = new Size(110, 33);
            lbAlarmTitle.TabIndex = 4;
            lbAlarmTitle.Text = "Alarm!";
            // 
            // lbAlarmStatus
            // 
            lbAlarmStatus.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAlarmStatus.Location = new Point(60, 82);
            lbAlarmStatus.Name = "lbAlarmStatus";
            lbAlarmStatus.Size = new Size(156, 20);
            lbAlarmStatus.TabIndex = 5;
            lbAlarmStatus.Text = "Status";
            lbAlarmStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(222, 131);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AlarmsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 180);
            Controls.Add(button6);
            Controls.Add(lbAlarmStatus);
            Controls.Add(lbAlarmTitle);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(dateTimePicker1);
            Controls.Add(picBoxReminders);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AlarmsForm";
            Text = "AlarmsForm";
            Load += AlarmsForm_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxReminders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxReminders;
        private DateTimePicker dateTimePicker1;
        private Button btnStart;
        private Button btnStop;
        private Label lbAlarmTitle;
        private Label lbAlarmStatus;
        private ToolTip toolTip1;
        private Button button6;
    }
}
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
            picBoxReminders = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            btnStart = new Button();
            btnStop = new Button();
            lbAlarmTitle = new Label();
            lbAlarmStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxReminders).BeginInit();
            SuspendLayout();
            // 
            // picBoxReminders
            // 
            picBoxReminders.Image = Properties.Resources.bell;
            picBoxReminders.Location = new Point(12, 12);
            picBoxReminders.Name = "picBoxReminders";
            picBoxReminders.Size = new Size(64, 64);
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
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(141, 140);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
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
            // AlarmsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 180);
            Controls.Add(lbAlarmStatus);
            Controls.Add(lbAlarmTitle);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(dateTimePicker1);
            Controls.Add(picBoxReminders);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}
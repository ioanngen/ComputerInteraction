namespace Forms_Appointments
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(245, 7);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(335, 394);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(132, 372);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 11);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Appointment Title";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBox1.Location = new Point(0, 83);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Select Time";
            // 
            // button2
            // 
            button2.Location = new Point(132, 110);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 5;
            button2.Text = "Create";
            toolTip1.SetToolTip(button2, "Creates New Appointment");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Location = new Point(0, 56);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 6, 9, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // toolTip1
            // 
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(12, 362);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(41, 37);
            button6.TabIndex = 9;
            toolTip1.SetToolTip(button6, "Help");
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 410);
            Controls.Add(button6);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Calendar";
            Text = "Apointments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private ToolTip toolTip1;
        private Button button6;
    }
}
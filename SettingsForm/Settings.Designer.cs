namespace SettingsForm
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabPage1 = new TabPage();
            label5 = new Label();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            button6 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            trackBar1 = new TrackBar();
            label6 = new Label();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(328, 309);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(416, 309);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(504, 309);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 29);
            button3.TabIndex = 3;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(trackBar1);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(580, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 21);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 9;
            label5.Text = "Language:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "English", "Greek", "German", "French", "Italian", "Spanish" });
            comboBox2.Location = new Point(374, 19);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 23);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "English";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(374, 92);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Age Restrictions";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 55);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Location:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Athens", "Patra", "Thessaloniki", "Kalamata", "Kifissia", "Glyfada", "Neos Voutzas", "Penteli", "Aigaleo" });
            comboBox1.Location = new Point(374, 52);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Athens";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 67);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 3);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(588, 299);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(580, 271);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 189);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 22;
            label1.Text = "Change your Password:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 50);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Surname";
            textBox6.Size = new Size(219, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 25);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Name";
            textBox4.Size = new Size(219, 23);
            textBox4.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 142);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 19;
            label2.Text = "Birthday:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 160);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(302, 23);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2001, 6, 22, 0, 0, 0, 0);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 231);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "*Re-enter Password";
            textBox5.Size = new Size(302, 23);
            textBox5.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 206);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "*New Password";
            textBox3.Size = new Size(302, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 115);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "*Email";
            textBox2.Size = new Size(302, 23);
            textBox2.TabIndex = 15;
            textBox2.Text = "user@test.com";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 90);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "*User Name";
            textBox7.Size = new Size(219, 23);
            textBox7.TabIndex = 14;
            textBox7.Text = "User";
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(8, 302);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(38, 36);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 17);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Wi-Fi";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 42);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Bluetooth";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(21, 67);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 19);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "Location";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(30, 198);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(165, 45);
            trackBar1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 180);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 14;
            label6.Text = "Brightness";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 346);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(614, 385);
            MinimumSize = new Size(614, 385);
            Name = "Settings";
            Text = "Settings";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Label label3;
        private ComboBox comboBox1;
        private TabPage tabPage2;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox7;
        private Label label1;
        private RadioButton radioButton1;
        private Label label4;
        private Button button6;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TrackBar trackBar1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
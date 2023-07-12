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
            label5 = new Label();
            comboBox2 = new ComboBox();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(376, 417);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(476, 417);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(576, 417);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(664, 378);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(115, 139);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Age Restrictions";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 89);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Location:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Athens", "Patra", "Thessaloniki", "Kalamata", "Kifissia", "Glyfada", "Neos Voutzas", "Penteli", "Aigaleo" });
            comboBox1.Location = new Point(115, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Athens";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 411);
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(664, 378);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 252);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 22;
            label1.Text = "Change your Password:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(37, 69);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Surname";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(37, 36);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Name";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 190);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 19;
            label2.Text = "Birthday:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(37, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(344, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2001, 6, 22, 0, 0, 0, 0);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(37, 308);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "*Re-enter Password";
            textBox5.Size = new Size(344, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 275);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "*New Password";
            textBox3.Size = new Size(344, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 160);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "*Email";
            textBox2.Size = new Size(344, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "user@test.com";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(37, 127);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "*User Name";
            textBox7.Size = new Size(250, 27);
            textBox7.TabIndex = 14;
            textBox7.Text = "User";
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(9, 413);
            button6.Name = "button6";
            button6.Size = new Size(35, 37);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 44);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 9;
            label5.Text = "Language:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "English", "Greek", "German", "French", "Italian", "Spanish" });
            comboBox2.Location = new Point(115, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 28);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "English";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "Settings";
            Text = "Settings";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
    }
}
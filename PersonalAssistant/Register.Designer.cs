namespace PersonalAssistant
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(494, 307);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 32);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 159);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "*User Name";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 159);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "*Email";
            textBox2.Size = new Size(302, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(327, 220);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "*Password";
            textBox3.Size = new Size(302, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(327, 247);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "*Re-enter Password";
            textBox5.Size = new Size(302, 23);
            textBox5.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 220);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(302, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 203);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 7;
            label1.Text = "*Choose your Birthday:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 91);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Name";
            textBox4.Size = new Size(302, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(10, 118);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Surname";
            textBox6.Size = new Size(302, 23);
            textBox6.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 255);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 10;
            label2.Text = "Fields with * are required.";
            // 
            // button2
            // 
            button2.Location = new Point(10, 307);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(135, 32);
            button2.TabIndex = 11;
            button2.Text = "Log In";
            toolTip1.SetToolTip(button2, "Go To LogIn Window");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 74);
            label3.Name = "label3";
            label3.Size = new Size(178, 15);
            label3.TabIndex = 13;
            label3.Text = "Sign the Below fileds to Register:";
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(590, 11);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(39, 36);
            button6.TabIndex = 14;
            toolTip1.SetToolTip(button6, "Help");
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 350);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label2;
        private Button button2;
        private Label label3;
        private ToolTip toolTip1;
        private Button button6;
    }
}
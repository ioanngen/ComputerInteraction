namespace Contacts
{
    partial class AddContact
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
            nameTextBox = new TextBox();
            label1 = new Label();
            phoneNumberLabel = new Label();
            phoneTextBox = new TextBox();
            homeNumberLabel = new Label();
            companyNumberLabel = new Label();
            homeNumberTextbox = new TextBox();
            companyNumberTextbox = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(256, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(12, 63);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 15);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(12, 81);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(256, 23);
            phoneTextBox.TabIndex = 3;
            phoneTextBox.Text = "Phone Number";
            // 
            // homeNumberLabel
            // 
            homeNumberLabel.AutoSize = true;
            homeNumberLabel.Location = new Point(12, 117);
            homeNumberLabel.Name = "homeNumberLabel";
            homeNumberLabel.Size = new Size(90, 15);
            homeNumberLabel.TabIndex = 4;
            homeNumberLabel.Text = "Home Number:";
            homeNumberLabel.Click += label3_Click;
            // 
            // companyNumberLabel
            // 
            companyNumberLabel.AutoSize = true;
            companyNumberLabel.Location = new Point(12, 171);
            companyNumberLabel.Name = "companyNumberLabel";
            companyNumberLabel.Size = new Size(109, 15);
            companyNumberLabel.TabIndex = 5;
            companyNumberLabel.Text = "Company Number:";
            // 
            // homeNumberTextbox
            // 
            homeNumberTextbox.Location = new Point(12, 135);
            homeNumberTextbox.Name = "homeNumberTextbox";
            homeNumberTextbox.Size = new Size(256, 23);
            homeNumberTextbox.TabIndex = 6;
            homeNumberTextbox.Text = "Home Number";
            // 
            // companyNumberTextbox
            // 
            companyNumberTextbox.Location = new Point(12, 189);
            companyNumberTextbox.Name = "companyNumberTextbox";
            companyNumberTextbox.Size = new Size(256, 23);
            companyNumberTextbox.TabIndex = 7;
            companyNumberTextbox.Text = "Company Number";
            // 
            // button1
            // 
            button1.Location = new Point(12, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(102, 218);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(193, 218);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Call";
            button4.UseVisualStyleBackColor = true;
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 258);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(companyNumberTextbox);
            Controls.Add(homeNumberTextbox);
            Controls.Add(companyNumberLabel);
            Controls.Add(homeNumberLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Name = "AddContact";
            Text = "Add Contact";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private Label phoneNumberLabel;
        private TextBox phoneTextBox;
        private Label homeNumberLabel;
        private Label companyNumberLabel;
        private TextBox homeNumberTextbox;
        private TextBox companyNumberTextbox;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
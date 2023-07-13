﻿namespace CallsAndMessages
{
    partial class MessagesForm
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
            NumberLabel = new Label();
            numberTextBox = new TextBox();
            label1 = new Label();
            messageTextBox = new TextBox();
            buttonSend = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumberLabel.Location = new Point(12, 9);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(76, 18);
            NumberLabel.TabIndex = 0;
            NumberLabel.Text = "Number:";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(12, 30);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(256, 23);
            numberTextBox.TabIndex = 1;
            numberTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 2;
            label1.Text = "Message:";
            label1.Click += label1_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 89);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(256, 256);
            messageTextBox.TabIndex = 3;
            messageTextBox.TextChanged += textBox2_TextChanged;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(193, 351);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(112, 351);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button2_Click;
            // 
            // MessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 382);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSend);
            Controls.Add(messageTextBox);
            Controls.Add(label1);
            Controls.Add(numberTextBox);
            Controls.Add(NumberLabel);
            Name = "MessagesForm";
            Text = "Messages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumberLabel;
        private TextBox numberTextBox;
        private Label label1;
        private TextBox messageTextBox;
        private Button buttonSend;
        private Button buttonCancel;
    }
}
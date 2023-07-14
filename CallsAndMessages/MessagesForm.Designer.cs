namespace CallsAndMessages
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
            components = new System.ComponentModel.Container();
            NumberLabel = new Label();
            numberTextBox = new TextBox();
            label1 = new Label();
            messageTextBox = new TextBox();
            buttonSend = new Button();
            buttonCancel = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumberLabel.Location = new Point(14, 12);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(95, 23);
            NumberLabel.TabIndex = 0;
            NumberLabel.Text = "Number:";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(14, 40);
            numberTextBox.Margin = new Padding(3, 4, 3, 4);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.PlaceholderText = "ex. 1234567890";
            numberTextBox.Size = new Size(292, 27);
            numberTextBox.TabIndex = 1;
            toolTip1.SetToolTip(numberTextBox, "Type the number");
            numberTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 91);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 2;
            label1.Text = "Message:";
            label1.Click += label1_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(14, 119);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "ex. Hello";
            messageTextBox.Size = new Size(292, 340);
            messageTextBox.TabIndex = 3;
            toolTip1.SetToolTip(messageTextBox, "Type your message");
            messageTextBox.TextChanged += textBox2_TextChanged;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(221, 468);
            buttonSend.Margin = new Padding(3, 4, 3, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(86, 31);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(128, 468);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 31);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button2_Click;
            // 
            // MessagesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 509);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSend);
            Controls.Add(messageTextBox);
            Controls.Add(label1);
            Controls.Add(numberTextBox);
            Controls.Add(NumberLabel);
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolTip toolTip1;
    }
}
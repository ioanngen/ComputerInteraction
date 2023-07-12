namespace CallsAndMessages
{
    partial class CallsAndMessagesForm
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
            CallsButton = new Button();
            MessagesButton = new Button();
            SuspendLayout();
            // 
            // CallsButton
            // 
            CallsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CallsButton.Image = Properties.Resources.telephone_call;
            CallsButton.Location = new Point(12, 12);
            CallsButton.Name = "CallsButton";
            CallsButton.Size = new Size(258, 289);
            CallsButton.TabIndex = 0;
            CallsButton.UseVisualStyleBackColor = true;
            CallsButton.Click += CallsButton_Click;
            // 
            // MessagesButton
            // 
            MessagesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MessagesButton.Image = Properties.Resources.comments;
            MessagesButton.Location = new Point(276, 12);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(256, 289);
            MessagesButton.TabIndex = 1;
            MessagesButton.UseVisualStyleBackColor = true;
            MessagesButton.Click += MessagesButton_Click;
            // 
            // CallsAndMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(544, 313);
            Controls.Add(MessagesButton);
            Controls.Add(CallsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CallsAndMessagesForm";
            Text = "Calls and Messages";
            ResumeLayout(false);
        }

        #endregion

        private Button CallsButton;
        private Button MessagesButton;
    }
}
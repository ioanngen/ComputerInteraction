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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallsAndMessagesForm));
            CallsButton = new Button();
            MessagesButton = new Button();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            SuspendLayout();
            // 
            // CallsButton
            // 
            CallsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CallsButton.Image = Properties.Resources.telephone_call;
            CallsButton.Location = new Point(12, 12);
            CallsButton.Name = "CallsButton";
            CallsButton.Size = new Size(258, 265);
            CallsButton.TabIndex = 0;
            toolTip1.SetToolTip(CallsButton, "Calls");
            CallsButton.UseVisualStyleBackColor = true;
            CallsButton.Click += CallsButton_Click;
            // 
            // MessagesButton
            // 
            MessagesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MessagesButton.Image = Properties.Resources.comments;
            MessagesButton.Location = new Point(276, 12);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(256, 265);
            MessagesButton.TabIndex = 1;
            toolTip1.SetToolTip(MessagesButton, "Messages");
            MessagesButton.UseVisualStyleBackColor = true;
            MessagesButton.Click += MessagesButton_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(490, 282);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // CallsAndMessagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(544, 326);
            Controls.Add(button6);
            Controls.Add(MessagesButton);
            Controls.Add(CallsButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CallsAndMessagesForm";
            Text = "Calls and Messages";
            ResumeLayout(false);
        }

        #endregion

        private Button CallsButton;
        private Button MessagesButton;
        private ToolTip toolTip1;
        private Button button6;
    }
}
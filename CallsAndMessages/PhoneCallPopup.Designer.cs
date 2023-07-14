namespace CallsAndMessages
{
    partial class PhoneCallPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneCallPopup));
            pictureBoxEndCall = new PictureBox();
            labelCalling = new Label();
            pictureBoxSpeaker = new PictureBox();
            pictureBoxMute = new PictureBox();
            phoneNumLabel = new Label();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEndCall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpeaker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMute).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxEndCall
            // 
            pictureBoxEndCall.Image = Properties.Resources.phone_call_end;
            pictureBoxEndCall.Location = new Point(119, 92);
            pictureBoxEndCall.Name = "pictureBoxEndCall";
            pictureBoxEndCall.Size = new Size(65, 70);
            pictureBoxEndCall.TabIndex = 0;
            pictureBoxEndCall.TabStop = false;
            toolTip1.SetToolTip(pictureBoxEndCall, "End the Call");
            pictureBoxEndCall.Click += pictureBoxEndCall_Click;
            // 
            // labelCalling
            // 
            labelCalling.AutoSize = true;
            labelCalling.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCalling.Location = new Point(75, 9);
            labelCalling.Name = "labelCalling";
            labelCalling.Size = new Size(140, 33);
            labelCalling.TabIndex = 1;
            labelCalling.Text = "Calling...";
            // 
            // pictureBoxSpeaker
            // 
            pictureBoxSpeaker.Image = Properties.Resources.speaker_filled_audio_tool;
            pictureBoxSpeaker.Location = new Point(47, 92);
            pictureBoxSpeaker.Name = "pictureBoxSpeaker";
            pictureBoxSpeaker.Size = new Size(48, 48);
            pictureBoxSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSpeaker.TabIndex = 2;
            pictureBoxSpeaker.TabStop = false;
            toolTip1.SetToolTip(pictureBoxSpeaker, "On Speaker");
            // 
            // pictureBoxMute
            // 
            pictureBoxMute.Image = Properties.Resources.mute_microphone;
            pictureBoxMute.Location = new Point(205, 92);
            pictureBoxMute.Name = "pictureBoxMute";
            pictureBoxMute.Size = new Size(48, 48);
            pictureBoxMute.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMute.TabIndex = 3;
            pictureBoxMute.TabStop = false;
            toolTip1.SetToolTip(pictureBoxMute, "Mute/Unmute");
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(88, 42);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(110, 22);
            phoneNumLabel.TabIndex = 4;
            phoneNumLabel.Text = "6972222222";
            phoneNumLabel.Click += phoneNumLabel_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(238, 11);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // PhoneCallPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 185);
            Controls.Add(button6);
            Controls.Add(phoneNumLabel);
            Controls.Add(pictureBoxMute);
            Controls.Add(pictureBoxSpeaker);
            Controls.Add(labelCalling);
            Controls.Add(pictureBoxEndCall);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PhoneCallPopup";
            Text = "Calling...";
            ((System.ComponentModel.ISupportInitialize)pictureBoxEndCall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpeaker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxEndCall;
        private Label labelCalling;
        private PictureBox pictureBoxSpeaker;
        private PictureBox pictureBoxMute;
        private Label phoneNumLabel;
        private ToolTip toolTip1;
        private Button button6;
    }
}
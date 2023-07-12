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
            pictureBoxEndCall = new PictureBox();
            labelCalling = new Label();
            pictureBoxSpeaker = new PictureBox();
            pictureBoxMute = new PictureBox();
            phoneNumLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEndCall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpeaker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMute).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxEndCall
            // 
            pictureBoxEndCall.Image = Properties.Resources.phone_call_end;
            pictureBoxEndCall.Location = new Point(66, 67);
            pictureBoxEndCall.Name = "pictureBoxEndCall";
            pictureBoxEndCall.Size = new Size(64, 64);
            pictureBoxEndCall.TabIndex = 0;
            pictureBoxEndCall.TabStop = false;
            pictureBoxEndCall.Click += pictureBoxEndCall_Click;
            // 
            // labelCalling
            // 
            labelCalling.AutoSize = true;
            labelCalling.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCalling.Location = new Point(33, 9);
            labelCalling.Name = "labelCalling";
            labelCalling.Size = new Size(140, 33);
            labelCalling.TabIndex = 1;
            labelCalling.Text = "Calling...";
            // 
            // pictureBoxSpeaker
            // 
            pictureBoxSpeaker.Image = Properties.Resources.speaker_filled_audio_tool;
            pictureBoxSpeaker.Location = new Point(12, 76);
            pictureBoxSpeaker.Name = "pictureBoxSpeaker";
            pictureBoxSpeaker.Size = new Size(48, 48);
            pictureBoxSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSpeaker.TabIndex = 2;
            pictureBoxSpeaker.TabStop = false;
            // 
            // pictureBoxMute
            // 
            pictureBoxMute.Image = Properties.Resources.mute_microphone;
            pictureBoxMute.Location = new Point(136, 76);
            pictureBoxMute.Name = "pictureBoxMute";
            pictureBoxMute.Size = new Size(48, 48);
            pictureBoxMute.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMute.TabIndex = 3;
            pictureBoxMute.TabStop = false;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(44, 42);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(110, 22);
            phoneNumLabel.TabIndex = 4;
            phoneNumLabel.Text = "6972222222";
            // 
            // PhoneCallPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 149);
            Controls.Add(phoneNumLabel);
            Controls.Add(pictureBoxMute);
            Controls.Add(pictureBoxSpeaker);
            Controls.Add(labelCalling);
            Controls.Add(pictureBoxEndCall);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}
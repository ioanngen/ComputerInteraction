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
            pictureBoxEndCall = new PictureBox();
            labelCalling = new Label();
            pictureBoxSpeaker = new PictureBox();
            pictureBoxMute = new PictureBox();
            phoneNumLabel = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxEndCall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpeaker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMute).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxEndCall
            // 
            pictureBoxEndCall.Image = Properties.Resources.phone_call_end;
            pictureBoxEndCall.Location = new Point(84, 101);
            pictureBoxEndCall.Margin = new Padding(3, 4, 3, 4);
            pictureBoxEndCall.Name = "pictureBoxEndCall";
            pictureBoxEndCall.Size = new Size(65, 76);
            pictureBoxEndCall.TabIndex = 0;
            pictureBoxEndCall.TabStop = false;
            toolTip1.SetToolTip(pictureBoxEndCall, "End the Call");
            pictureBoxEndCall.Click += pictureBoxEndCall_Click;
            // 
            // labelCalling
            // 
            labelCalling.AutoSize = true;
            labelCalling.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCalling.Location = new Point(38, 12);
            labelCalling.Name = "labelCalling";
            labelCalling.Size = new Size(179, 43);
            labelCalling.TabIndex = 1;
            labelCalling.Text = "Calling...";
            // 
            // pictureBoxSpeaker
            // 
            pictureBoxSpeaker.Image = Properties.Resources.speaker_filled_audio_tool;
            pictureBoxSpeaker.Location = new Point(14, 101);
            pictureBoxSpeaker.Margin = new Padding(3, 4, 3, 4);
            pictureBoxSpeaker.Name = "pictureBoxSpeaker";
            pictureBoxSpeaker.Size = new Size(55, 64);
            pictureBoxSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSpeaker.TabIndex = 2;
            pictureBoxSpeaker.TabStop = false;
            toolTip1.SetToolTip(pictureBoxSpeaker, "On Speaker");
            // 
            // pictureBoxMute
            // 
            pictureBoxMute.Image = Properties.Resources.mute_microphone;
            pictureBoxMute.Location = new Point(162, 101);
            pictureBoxMute.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMute.Name = "pictureBoxMute";
            pictureBoxMute.Size = new Size(55, 64);
            pictureBoxMute.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMute.TabIndex = 3;
            pictureBoxMute.TabStop = false;
            toolTip1.SetToolTip(pictureBoxMute, "Mute/Unmute");
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(50, 56);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(142, 28);
            phoneNumLabel.TabIndex = 4;
            phoneNumLabel.Text = "6972222222";
            // 
            // PhoneCallPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 199);
            Controls.Add(phoneNumLabel);
            Controls.Add(pictureBoxMute);
            Controls.Add(pictureBoxSpeaker);
            Controls.Add(labelCalling);
            Controls.Add(pictureBoxEndCall);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
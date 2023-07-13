namespace Maps
{
    partial class MapsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapsForm));
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.Navigate = new System.Windows.Forms.Button();
            this.DirectionsBox = new System.Windows.Forms.PictureBox();
            this.NextPoint = new System.Windows.Forms.Button();
            this.LocationTextArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapBox
            // 
            this.MapBox.Image = ((System.Drawing.Image)(resources.GetObject("MapBox.Image")));
            this.MapBox.Location = new System.Drawing.Point(42, 33);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(423, 282);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            // 
            // Navigate
            // 
            this.Navigate.FlatAppearance.BorderSize = 0;
            this.Navigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Navigate.Image = ((System.Drawing.Image)(resources.GetObject("Navigate.Image")));
            this.Navigate.Location = new System.Drawing.Point(409, 467);
            this.Navigate.Name = "Navigate";
            this.Navigate.Size = new System.Drawing.Size(56, 61);
            this.Navigate.TabIndex = 1;
            this.Navigate.UseVisualStyleBackColor = true;
            this.Navigate.Click += new System.EventHandler(this.Navigate_Click);
            // 
            // DirectionsBox
            // 
            this.DirectionsBox.Image = ((System.Drawing.Image)(resources.GetObject("DirectionsBox.Image")));
            this.DirectionsBox.Location = new System.Drawing.Point(42, 335);
            this.DirectionsBox.Name = "DirectionsBox";
            this.DirectionsBox.Size = new System.Drawing.Size(361, 115);
            this.DirectionsBox.TabIndex = 3;
            this.DirectionsBox.TabStop = false;
            // 
            // NextPoint
            // 
            this.NextPoint.Enabled = false;
            this.NextPoint.FlatAppearance.BorderSize = 0;
            this.NextPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPoint.Image = ((System.Drawing.Image)(resources.GetObject("NextPoint.Image")));
            this.NextPoint.Location = new System.Drawing.Point(409, 361);
            this.NextPoint.Name = "NextPoint";
            this.NextPoint.Size = new System.Drawing.Size(56, 62);
            this.NextPoint.TabIndex = 4;
            this.NextPoint.UseVisualStyleBackColor = true;
            this.NextPoint.Click += new System.EventHandler(this.NextPoint_Click);
            // 
            // LocationTextArea
            // 
            this.LocationTextArea.Location = new System.Drawing.Point(42, 481);
            this.LocationTextArea.Multiline = true;
            this.LocationTextArea.Name = "LocationTextArea";
            this.LocationTextArea.Size = new System.Drawing.Size(361, 47);
            this.LocationTextArea.TabIndex = 5;
            // 
            // MapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 554);
            this.Controls.Add(this.LocationTextArea);
            this.Controls.Add(this.NextPoint);
            this.Controls.Add(this.DirectionsBox);
            this.Controls.Add(this.Navigate);
            this.Controls.Add(this.MapBox);
            this.Name = "MapsForm";
            this.Text = "Map Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MapBox;
        private Button Navigate;
        private PictureBox DirectionsBox;
        private Button NextPoint;
        private TextBox LocationTextArea;
    }
}
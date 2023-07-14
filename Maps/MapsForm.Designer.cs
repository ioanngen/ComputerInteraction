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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapsForm));
            MapBox = new PictureBox();
            Navigate = new Button();
            DirectionsBox = new PictureBox();
            NextPoint = new Button();
            LocationTextArea = new TextBox();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)MapBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DirectionsBox).BeginInit();
            SuspendLayout();
            // 
            // MapBox
            // 
            MapBox.Image = (Image)resources.GetObject("MapBox.Image");
            MapBox.Location = new Point(12, 11);
            MapBox.Margin = new Padding(3, 2, 3, 2);
            MapBox.Name = "MapBox";
            MapBox.Size = new Size(370, 212);
            MapBox.TabIndex = 0;
            MapBox.TabStop = false;
            toolTip1.SetToolTip(MapBox, "Map");
            // 
            // Navigate
            // 
            Navigate.FlatAppearance.BorderSize = 0;
            Navigate.FlatStyle = FlatStyle.Flat;
            Navigate.Image = (Image)resources.GetObject("Navigate.Image");
            Navigate.Location = new Point(405, 356);
            Navigate.Margin = new Padding(3, 2, 3, 2);
            Navigate.Name = "Navigate";
            Navigate.Size = new Size(60, 61);
            Navigate.TabIndex = 1;
            toolTip1.SetToolTip(Navigate, "Search for Places");
            Navigate.UseVisualStyleBackColor = true;
            Navigate.Click += Navigate_Click;
            // 
            // DirectionsBox
            // 
            DirectionsBox.Image = (Image)resources.GetObject("DirectionsBox.Image");
            DirectionsBox.Location = new Point(12, 238);
            DirectionsBox.Margin = new Padding(3, 2, 3, 2);
            DirectionsBox.Name = "DirectionsBox";
            DirectionsBox.Size = new Size(370, 121);
            DirectionsBox.TabIndex = 3;
            DirectionsBox.TabStop = false;
            toolTip1.SetToolTip(DirectionsBox, "Directions");
            // 
            // NextPoint
            // 
            NextPoint.Enabled = false;
            NextPoint.FlatAppearance.BorderSize = 0;
            NextPoint.FlatStyle = FlatStyle.Flat;
            NextPoint.Image = (Image)resources.GetObject("NextPoint.Image");
            NextPoint.Location = new Point(405, 271);
            NextPoint.Margin = new Padding(3, 2, 3, 2);
            NextPoint.Name = "NextPoint";
            NextPoint.Size = new Size(46, 56);
            NextPoint.TabIndex = 4;
            toolTip1.SetToolTip(NextPoint, "Next");
            NextPoint.UseVisualStyleBackColor = true;
            NextPoint.Click += NextPoint_Click;
            // 
            // LocationTextArea
            // 
            LocationTextArea.Location = new Point(12, 376);
            LocationTextArea.Margin = new Padding(3, 2, 3, 2);
            LocationTextArea.Multiline = true;
            LocationTextArea.Name = "LocationTextArea";
            LocationTextArea.Size = new Size(370, 36);
            LocationTextArea.TabIndex = 5;
            toolTip1.SetToolTip(LocationTextArea, "Type here your Destination");
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(433, 11);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // MapsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 435);
            Controls.Add(button6);
            Controls.Add(LocationTextArea);
            Controls.Add(NextPoint);
            Controls.Add(DirectionsBox);
            Controls.Add(Navigate);
            Controls.Add(MapBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MapsForm";
            Text = "Map Navigation";
            ((System.ComponentModel.ISupportInitialize)MapBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DirectionsBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MapBox;
        private Button Navigate;
        private PictureBox DirectionsBox;
        private Button NextPoint;
        private TextBox LocationTextArea;
        private ToolTip toolTip1;
        private Button button6;
    }
}
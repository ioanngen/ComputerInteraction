namespace PersonalAssistant
{
    partial class ViewSavedProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSavedProjects));
            dataGridView1 = new DataGridView();
            Exit = new Button();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(404, 148);
            dataGridView1.TabIndex = 0;
            toolTip1.SetToolTip(dataGridView1, "These are your Saved Projects");
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(172, 161);
            Exit.Margin = new Padding(3, 2, 3, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(70, 63);
            Exit.TabIndex = 1;
            toolTip1.SetToolTip(Exit, "Exit");
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(372, 183);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // ViewSavedProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 233);
            Controls.Add(button6);
            Controls.Add(Exit);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ViewSavedProjects";
            Text = "ViewSavedProjects";
            Load += ViewSavedProjects_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Exit;
        private ToolTip toolTip1;
        private Button button6;
    }
}
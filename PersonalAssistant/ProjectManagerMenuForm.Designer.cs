namespace PersonalAssistant
{
    partial class ProjectManagerMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerMenuForm));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            AddNewProject = new Button();
            ViewSavedProjects = new Button();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(35, 28);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(113, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "Add a new project";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(195, 28);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(137, 16);
            textBox2.TabIndex = 1;
            textBox2.Text = "View saved projects";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // AddNewProject
            // 
            AddNewProject.FlatAppearance.BorderSize = 0;
            AddNewProject.FlatStyle = FlatStyle.Flat;
            AddNewProject.Image = (Image)resources.GetObject("AddNewProject.Image");
            AddNewProject.Location = new Point(65, 55);
            AddNewProject.Margin = new Padding(3, 2, 3, 2);
            AddNewProject.Name = "AddNewProject";
            AddNewProject.Size = new Size(57, 60);
            AddNewProject.TabIndex = 2;
            toolTip1.SetToolTip(AddNewProject, "Add a new project");
            AddNewProject.UseVisualStyleBackColor = true;
            AddNewProject.Click += AddNewProject_Click;
            // 
            // ViewSavedProjects
            // 
            ViewSavedProjects.FlatAppearance.BorderSize = 0;
            ViewSavedProjects.FlatStyle = FlatStyle.Flat;
            ViewSavedProjects.Image = (Image)resources.GetObject("ViewSavedProjects.Image");
            ViewSavedProjects.Location = new Point(235, 49);
            ViewSavedProjects.Margin = new Padding(3, 2, 3, 2);
            ViewSavedProjects.Name = "ViewSavedProjects";
            ViewSavedProjects.Size = new Size(72, 73);
            ViewSavedProjects.TabIndex = 3;
            toolTip1.SetToolTip(ViewSavedProjects, "View saved projects");
            ViewSavedProjects.UseVisualStyleBackColor = true;
            ViewSavedProjects.Click += ViewSavedProjects_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(160, 98);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // ProjectManagerMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 150);
            Controls.Add(button6);
            Controls.Add(ViewSavedProjects);
            Controls.Add(AddNewProject);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ProjectManagerMenuForm";
            Text = "ProjectManagerMenuForm";
            Load += ProjectManagerMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddNewProject;
        private Button ViewSavedProjects;
        private ToolTip toolTip1;
        private Button button6;
    }
}
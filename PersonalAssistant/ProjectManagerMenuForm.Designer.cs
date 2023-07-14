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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerMenuForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddNewProject = new System.Windows.Forms.Button();
            this.ViewSavedProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(40, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Add a new project";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(223, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "View saved projects";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddNewProject
            // 
            this.AddNewProject.FlatAppearance.BorderSize = 0;
            this.AddNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProject.Image = ((System.Drawing.Image)(resources.GetObject("AddNewProject.Image")));
            this.AddNewProject.Location = new System.Drawing.Point(80, 78);
            this.AddNewProject.Name = "AddNewProject";
            this.AddNewProject.Size = new System.Drawing.Size(58, 57);
            this.AddNewProject.TabIndex = 2;
            this.AddNewProject.UseVisualStyleBackColor = true;
            this.AddNewProject.Click += new System.EventHandler(this.AddNewProject_Click);
            // 
            // ViewSavedProjects
            // 
            this.ViewSavedProjects.FlatAppearance.BorderSize = 0;
            this.ViewSavedProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSavedProjects.Image = ((System.Drawing.Image)(resources.GetObject("ViewSavedProjects.Image")));
            this.ViewSavedProjects.Location = new System.Drawing.Point(265, 73);
            this.ViewSavedProjects.Name = "ViewSavedProjects";
            this.ViewSavedProjects.Size = new System.Drawing.Size(72, 66);
            this.ViewSavedProjects.TabIndex = 3;
            this.ViewSavedProjects.UseVisualStyleBackColor = true;
            this.ViewSavedProjects.Click += new System.EventHandler(this.ViewSavedProjects_Click);
            // 
            // ProjectManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 185);
            this.Controls.Add(this.ViewSavedProjects);
            this.Controls.Add(this.AddNewProject);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectManagerMenuForm";
            this.Text = "ProjectManagerMenuForm";
            this.Load += new System.EventHandler(this.ProjectManagerMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddNewProject;
        private Button ViewSavedProjects;
    }
}
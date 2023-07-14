namespace PersonalAssistant
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectDesc = new System.Windows.Forms.TextBox();
            this.SaveProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(297, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(30, 42);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(198, 27);
            this.ProjectName.TabIndex = 1;
            this.ProjectName.Text = "Project name";
            this.ProjectName.Click += new System.EventHandler(this.ProjectName_Click);
            // 
            // ProjectDesc
            // 
            this.ProjectDesc.Location = new System.Drawing.Point(30, 87);
            this.ProjectDesc.Multiline = true;
            this.ProjectDesc.Name = "ProjectDesc";
            this.ProjectDesc.Size = new System.Drawing.Size(198, 119);
            this.ProjectDesc.TabIndex = 2;
            this.ProjectDesc.Text = "Project description";
            this.ProjectDesc.Click += new System.EventHandler(this.ProjectDesc_Click);
            // 
            // SaveProject
            // 
            this.SaveProject.FlatAppearance.BorderSize = 0;
            this.SaveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProject.Image = ((System.Drawing.Image)(resources.GetObject("SaveProject.Image")));
            this.SaveProject.Location = new System.Drawing.Point(93, 212);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(65, 63);
            this.SaveProject.TabIndex = 3;
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 313);
            this.Controls.Add(this.SaveProject);
            this.Controls.Add(this.ProjectDesc);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox ProjectName;
        private TextBox ProjectDesc;
        private Button SaveProject;
    }
}
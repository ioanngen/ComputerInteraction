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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            monthCalendar1 = new MonthCalendar();
            ProjectName = new TextBox();
            ProjectDesc = new TextBox();
            SaveProject = new Button();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(260, 32);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // ProjectName
            // 
            ProjectName.Location = new Point(26, 32);
            ProjectName.Margin = new Padding(3, 2, 3, 2);
            ProjectName.Name = "ProjectName";
            ProjectName.PlaceholderText = "Project name";
            ProjectName.Size = new Size(174, 23);
            ProjectName.TabIndex = 1;
            ProjectName.Click += ProjectName_Click;
            // 
            // ProjectDesc
            // 
            ProjectDesc.Location = new Point(26, 65);
            ProjectDesc.Margin = new Padding(3, 2, 3, 2);
            ProjectDesc.Multiline = true;
            ProjectDesc.Name = "ProjectDesc";
            ProjectDesc.PlaceholderText = "Project description";
            ProjectDesc.Size = new Size(174, 90);
            ProjectDesc.TabIndex = 2;
            ProjectDesc.Click += ProjectDesc_Click;
            // 
            // SaveProject
            // 
            SaveProject.FlatAppearance.BorderSize = 0;
            SaveProject.FlatStyle = FlatStyle.Flat;
            SaveProject.Image = (Image)resources.GetObject("SaveProject.Image");
            SaveProject.Location = new Point(83, 159);
            SaveProject.Margin = new Padding(3, 2, 3, 2);
            SaveProject.Name = "SaveProject";
            SaveProject.Size = new Size(57, 47);
            SaveProject.TabIndex = 3;
            toolTip1.SetToolTip(SaveProject, "Add Project");
            SaveProject.UseVisualStyleBackColor = true;
            SaveProject.Click += SaveProject_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(12, 183);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 235);
            Controls.Add(button6);
            Controls.Add(SaveProject);
            Controls.Add(ProjectDesc);
            Controls.Add(ProjectName);
            Controls.Add(monthCalendar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddProject";
            Text = "AddProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox ProjectName;
        private TextBox ProjectDesc;
        private Button SaveProject;
        private ToolTip toolTip1;
        private Button button6;
    }
}
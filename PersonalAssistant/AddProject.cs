using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalAssistant
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }
        private void ProjectName_Click(object sender, EventArgs e)
        {
            ProjectName.Text = "";
        }
        private void ProjectDesc_Click(object sender, EventArgs e)
        {
            ProjectDesc.Text = "";
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            bool cantSave = false;
            if (ProjectName.Text == "")
            {
                MessageBox.Show("Please enter a valid project name.", "Name error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cantSave = true;
            }
            if (ProjectDesc.Text == "")
            {
                MessageBox.Show("Please enter a valid project description.", "Description error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cantSave = true;
            }
            if (!cantSave)
            {
                DialogResult result = MessageBox.Show("Project saved successfully, do you wish to add more projects?.", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    this.Dispose();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "If you want to add a new project, you have to type the Project Name and Description in the right fields," +
                "and also choose a deadline from the calendar at the right of screen. To save the Project click on Save button.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

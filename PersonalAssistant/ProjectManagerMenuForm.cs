using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAssistant
{
    public partial class ProjectManagerMenuForm : Form
    {
        public ProjectManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ProjectManagerMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void AddNewProject_Click(object sender, EventArgs e)
        {
            var newform = new AddProject();
            newform.Show();
        }

        private void ViewSavedProjects_Click(object sender, EventArgs e)
        {
            var newform = new ViewSavedProjects();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "In this window you can choose if you want to create a new Project or " +
                "to see a list of all your existing projects.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

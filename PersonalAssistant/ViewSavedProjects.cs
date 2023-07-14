using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAssistant
{
    public partial class ViewSavedProjects : Form
    {
        DataTable mockdata = new DataTable();
        public ViewSavedProjects()
        {
            InitializeComponent();
        }

        private void ViewSavedProjects_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mockdata.Columns.Add("Project_Name");
            mockdata.Columns.Add("Project_Description");

            mockdata.Rows.Add("Human Computer Interaction", "Make a personal assistant app");
            mockdata.Rows.Add("Electronic Learning", "Make a game using unity");
            mockdata.Rows.Add("Object oriented programming", "Create a c++ app");
            mockdata.Rows.Add("Software quality and reliability", "Write a paper about the ISO specification");
            dataGridView1.DataSource = mockdata;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?", "Exit.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "Here you can see a list of all your existing projects in your Personal Assistant." +
                "To exit click on the button below at the center of the window.";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

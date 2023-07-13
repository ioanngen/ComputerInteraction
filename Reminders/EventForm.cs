using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reminders
{
    public partial class EventForm : Form
    {

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = UserControlDays.static_day + "/" + RemindersForm.static_month + "/" + RemindersForm.static_year;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
            this.Close();
        }

        private void txevent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

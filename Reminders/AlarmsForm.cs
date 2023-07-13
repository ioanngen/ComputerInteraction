using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminders
{
    public partial class AlarmsForm : Form
    {
        System.Timers.Timer timer;

        public AlarmsForm()
        {
            InitializeComponent();
        }

        private void picBoxReminders_Click(object sender, EventArgs e)
        {
            var newform = new RemindersForm();
            newform.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AlarmsForm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void UpdateLable(Label lbl, string value);
        void UpdateDataLable(Label lbl, string value)
        {
            lbl.Text = value;
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLable upd = UpdateDataLable;
                    if (lbAlarmStatus.InvokeRequired)
                        Invoke(upd, lbAlarmStatus, "Stop");
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm05.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lbAlarmStatus.Text = "Running...";
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lbAlarmStatus.Text = "Stop";
        }
    }
}

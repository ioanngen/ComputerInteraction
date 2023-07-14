using System.Globalization;

namespace Reminders
{
    public partial class RemindersForm : Form
    {
        int month, year;

        // Static variable that we can pass to another form for month and year
        public static int static_month, static_year;


        public RemindersForm()
        {
            InitializeComponent();
        }

        private void RemindersForm_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;


            static_month = month;
            static_year = year;

            // First day of the month:

            DateTime startofthemonth = new DateTime(year, month, 1);

            // Get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Creating Blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            // Create user control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Clear contrainer
            daycontainer.Controls.Clear();

            // Increment month to go to next month
            month++;

            static_month = month;
            static_year = year;

            if (month > 12)
            {
                month = 1;
                year++;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            // Get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Creating Blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            // Create user control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // Clear contrainer
            daycontainer.Controls.Clear();

            // decreament month to go to next month
            month--;

            static_month = month;
            static_year = year;

            if (month < 1)
            {
                month = 12;
                year--;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            // Get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Creating Blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            // Create user control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void picBoxAlarm_Click(object sender, EventArgs e)
        {
            var newform = new AlarmsForm();
            newform.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newform = new EventForm();
            newform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "This is a reminders app. If you want to go to the alarms app, click the button on the upper right side of the window. " +
                                   "Choose the day you would like to add an event. Then on the window that pops up you can type the event or change  the " +
                                   "event date. On the middle down of the window you can choose between viewing a list of saved events, or add a new " +
                                   "event on your desided date. Scroll through the months with the buttons previous or next on the right down side of the " +
                                   "window. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
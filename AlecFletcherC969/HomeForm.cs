using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlecFletcherC969
{
    public partial class HomeForm : Form
    {
        public static string user;
        public static int userId;

        public static DateTime now = DateTime.Now;
        public static int month = now.Month;
        public static DateTime startOfTheMonth = new DateTime(now.Year, now.Month, 1);
        int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
        public static int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
        public TimeZone timeZone = TimeZone.CurrentTimeZone;
        bool isDaylightSavings = now.IsDaylightSavingTime();
        delegate bool MinutesBeforeMeeting(int mins);
        MinutesBeforeMeeting equalsOneMinute = (mins) => (mins == 1);
        
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(string username, int id)
        {
            InitializeComponent();
            Writer.WriteUserLogin(id, username);
            this.Text = "Home Page";
            user = username;
            userId = id;

        }

        //Generate appointments table so calendar tile constructor can run SetDayNum and begin generating calendar tiles to display the days for current month. 
        private void HomeForm_Load(object sender, EventArgs e)
        {
            DBTables.PopulateAppointments();


            //Instead of creating and naming a function that will be used 1 time and calling the function here, or creating a new Appointment type
            //and assigning the returned appointment from below, we can declare the appointment name in the same line and compare without performing
            //a foreach and if statement in that one method, thus saving space

            /*            foreach(Appointment apt in DBTables.AppointmentList)
                        {
                            if(DateTime.Now.AddMinutes(15) >= apt.start && new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) == new DateTime(apt.start.Year, apt.start.Month, apt.start.Day))
                            {
                                return apt;
                                (or local variable)appointment = apt
                            }
                        }*/

            //Lambda 2
            //Find the first appointment that is less than or equal to 15 minutes from now and ensures that the userId matches the current logged in user
            Appointment upcomingMeeting = DBTables.AppointmentList.Where(apt => (DateTime.Now.AddMinutes(15) >= apt.start.ToLocalTime() && DateTime.Now < apt.start.ToLocalTime() && new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) == new DateTime(apt.start.ToLocalTime().Year, apt.start.ToLocalTime().Month, apt.start.ToLocalTime().Day) && apt.userId == userId)).FirstOrDefault();
            //Lambda 2

            if(upcomingMeeting != null)
            {
                int numMins = upcomingMeeting.start.ToLocalTime().Minute - DateTime.Now.Minute;


                //Instead of applying an if statement on whether or not the number of minutes before a meeting was greater than 1, 
                //we can have a lambda function that integrates into the message box to make the message more appealing if the user
                //happens to log in 1 minute before the meetings

                //Lambda 3
                MessageBox.Show($"You have an appointment in {numMins} " + (equalsOneMinute(numMins)? "minutes." : "minute. ") + $"\nAppointment Title: {upcomingMeeting.title}");
                //Lambda 3
            }

            DBTables.PopulateAppointments();
            month_label.Text = DateTime.Now.ToString("MMMM");

            //If the first day of the week is on a friday or saturday and 6 rows would be needed to create a new calendar
            if(dayOfTheWeek == 5 && daysInMonth == 31 || dayOfTheWeek == 6 && daysInMonth >= 30)
            {
                this.Height = 792;
                calendarContainer.Height = 661;
            }

            //Create blank tiles for each day to offset properly for the first day of the month
            for (int i = 0; i < dayOfTheWeek; i++)
            {
                BlankTile blankTile = new BlankTile();
                calendarContainer.Controls.Add(blankTile);
            }

            //Create calendar day tiles for each day of the month
            for(int i = 1; i < daysInMonth + 1; i++)
            {
                CalendarDayTile calendarDayTile = new CalendarDayTile();
                calendarDayTile.day = i;
                calendarContainer.Controls.Add(calendarDayTile);
            }
        }

        private void weeklyview_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear calendarContainer and set height to accomodate for the smaller weekly view
            calendarContainer.Controls.Clear();
            this.Height = 386;
            calendarContainer.Height = 252;
            mainControls_groupbox.Location = new Point(1122, 1);

            //Create weekly tiles for each day between current day and sunday
            int weeklyViewDay = (int)DateTime.Now.DayOfWeek;
            for (int i = weeklyViewDay; i > 0; i--)
            {
                WeeklyCalendarTile weeklyTile = new WeeklyCalendarTile(DateTime.Now.AddDays(-i));
                calendarContainer.Controls.Add(weeklyTile);
            }

            //Add current day tile and highlight it to show the current day at a quite glance
            WeeklyCalendarTile currentDayTile = new WeeklyCalendarTile(DateTime.Now);
            currentDayTile.BackColor = Color.White;
            calendarContainer.Controls.Add(currentDayTile);

            //Add weekly tiles for each day between current day and saturday
            if(weeklyViewDay < 6)
            {
                int daysToAdd = (7 - weeklyViewDay);
                for(int i = 1; i <= daysToAdd; i++)
                {
                    WeeklyCalendarTile weeklyTile = new WeeklyCalendarTile(DateTime.Now.AddDays(i));
                    calendarContainer.Controls.Add(weeklyTile);
                }
            }
        }

        private void monthlyView_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the calendar for a fresh slate
            calendarContainer.Controls.Clear();
            mainControls_groupbox.Location = new Point(1122, 63);

            //If the first day of the week is on a friday or saturday and 6 rows would be needed to create a new calendar
            if (dayOfTheWeek == 5 && daysInMonth == 31 || dayOfTheWeek == 6 && daysInMonth >= 30)
            {
                this.Height = 792;
                calendarContainer.Height = 661;
            }

            //Otherwise, set the height to defaults for window and calendarContainer
            else
            {
                this.Height = 686;
                calendarContainer.Height = 552;
            }

            //Create blank tiles for each day to offset properly for the first day of the month
            for (int i = 0; i < dayOfTheWeek; i++)
            {
                BlankTile blankTile = new BlankTile();
                calendarContainer.Controls.Add(blankTile);
            }

            //Create calendar day tiles for each day of the month
            for (int i = 1; i < daysInMonth + 1; i++)
            {
                CalendarDayTile calendarDayTile = new CalendarDayTile();
                calendarDayTile.day = i;
                calendarContainer.Controls.Add(calendarDayTile);
            }
        }

        public void PopulateMonthlyView()
        {
            //Repopulate appointments for an updated list and repopulate the calendar
            DBTables.PopulateAppointments();
            calendarContainer.Controls.Clear();
            mainControls_groupbox.Location = new Point(1122, 63);

            //If the first day of the week is on a friday or saturday and 6 rows would be needed to create a new calendar
            if (dayOfTheWeek == 5 && daysInMonth == 31 || dayOfTheWeek == 6 && daysInMonth >= 30)
            {
                this.Height = 792;
                calendarContainer.Height = 661;
            }

            //Otherwise, set the height to defaults for window and calendarContainer
            else
            {
                this.Height = 686;
                calendarContainer.Height = 552;
            }

            //Create blank tiles for each day to offset properly for the first day of the month
            for (int i = 0; i < dayOfTheWeek; i++)
            {
                BlankTile blankTile = new BlankTile();
                calendarContainer.Controls.Add(blankTile);
            }

            //Create calendar day tiles for each day of the month
            for (int i = 1; i < daysInMonth + 1; i++)
            {
                CalendarDayTile calendarDayTile = new CalendarDayTile();
                calendarDayTile.day = i;
                calendarContainer.Controls.Add(calendarDayTile);
            }

        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            //Create an instance of CustomerForm and pop up a new window the it.
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();

        }

        private void modifyCustomer_button_Click(object sender, EventArgs e)
        {
            //Create instance of a customerListForm and pop up new window with that instance
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.Text = "Customer List";
            customerListForm.ShowDialog();
        }

        private void addAppointment_button_Click(object sender, EventArgs e)
        {
            //Create instance of appointment and repopulate the calendar after the window is closed
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Text = "Add Appointment";
            appointmentForm.ShowDialog();
            PopulateMonthlyView();
            monthlyView_radiobutton.Checked = true;
        }

        private void modifyAppointment_button_Click(object sender, EventArgs e)
        {
            //Create instance of appointment list and pop up window of instance
            AppointmentListForm appointmentList = new AppointmentListForm();
            appointmentList.Text = "Appointment List";
            appointmentList.ShowDialog();
        }

        private void reports_Button_Click(object sender, EventArgs e)
        {
            //Create instance of reportForm and instantiate it
            ReportForm reportForm = new ReportForm();
            reportForm.Text = "Reports";
            reportForm.ShowDialog();
        }
    }
}

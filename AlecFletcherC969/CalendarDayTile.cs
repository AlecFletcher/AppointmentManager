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
    public partial class CalendarDayTile : UserControl
    {
        public int day;
        public int numAppointments = 0;

        public CalendarDayTile()
        {
            InitializeComponent();
        }

        //On load, set the day for that calendar day tile. Also run SetDayNum helper function
        private void CalendarDayTile_Load(object sender, EventArgs e)
        {
            dayNum_label.Text = day.ToString();
            SetDayNum();
        }
        
        //Change color to give feedback when hovering over a calendar day
        private void CalendarDayTile_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.ActiveCaption;
        }

        //Change color back to default when no longer hovering the calendar day
        private void CalendarDayTile_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlLight;
        }

        //Cycle through each Appointment in AppointmentList and if the date matches the calendar day, sets the text in that calendar box to show how many appointments for that day
        private void SetDayNum()
        {
            foreach(var apt in DBTables.AppointmentList)
            {
                if (new DateTime(apt.start.Year, apt.start.Month, apt.start.Day) == new DateTime(DateTime.Now.Year, DateTime.Now.Month, day))
                {
                    numAppointments++;
                }
            }

            //If no appointments for that day
            if (numAppointments == 0)
            {
                appointmentNum_label.Visible = false;
            }
            //If only 1 appointment for that day
            else if (numAppointments == 1)
            {
                appointmentNum_label.Text = "1 Appointment";
            }
            //If multiple appointments for that day
            else
            {
                appointmentNum_label.Text = $"{numAppointments} Appointments";
            }
        }

        private void CalendarDayTile_Click(object sender, EventArgs e)
        {
            DailyAppointmentsForm aptForm = new DailyAppointmentsForm(new DateTime(DateTime.Now.Year, DateTime.Now.Month, day));
            aptForm.ShowDialog();
        }
    }
}

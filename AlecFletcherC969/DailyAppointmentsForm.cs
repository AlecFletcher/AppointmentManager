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
    public partial class DailyAppointmentsForm : Form
    {
        DateTime today = new DateTime();
        public DailyAppointmentsForm()
        {
            InitializeComponent();
        }

        public DailyAppointmentsForm(DateTime dateTime)
        {
            InitializeComponent();
            
            //Inherit passed datetime
            this.today = dateTime;

            //Style DGView
            appointmentsDG.Columns.Add("aptTitle", "Appointment Title");
            appointmentsDG.Columns.Add("aptDesc", "Appointment Description");
            appointmentsDG.Columns.Add("aptSchedule", "Appointment Schedule");
            appointmentsDG.Columns[0].Width = 137;
            appointmentsDG.Columns[1].Width = 137;
            appointmentsDG.Columns[2].Width = 200;
            this.Text = $"Appointments for {today.ToString("MMMM dd")}";
        }

        private void DailyAppointmentsForm_Load(object sender, EventArgs e)
        {
            //Check if any appointments in appointmentList match the inherited datetime and add it to DGView
            foreach(var apt in DBTables.AppointmentList)
            {
                if(apt.start.Month == today.Month && apt.start.Day == today.Day && apt.userId == HomeForm.userId)
                {
                    appointmentsDG.Rows.Add(apt.title, apt.description, $"{ apt.start.ToString("hh:mm tt")} - {apt.end.ToString("hh:mm tt")}");
                }
            }
            //Sort so appointments are in chronological order
            appointmentsDG.Sort(this.appointmentsDG.Columns["aptSchedule"], ListSortDirection.Ascending);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

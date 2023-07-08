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
    public partial class WeeklyCalendarTile : UserControl
    {
        public DateTime tileDay;

        public WeeklyCalendarTile()
        {
            InitializeComponent();
        }

        public WeeklyCalendarTile(DateTime date)
        {
            InitializeComponent();
            tileDay = date;
        }
        private void WeeklyCalendarTile_Load(object sender, EventArgs e)
        {
            day_label.Text = tileDay.Day.ToString();
            foreach (var apt in DBTables.AppointmentList)
            {
                if (new DateTime(apt.start.Year, apt.start.Month, apt.start.Day) == new DateTime(tileDay.Year, tileDay.Month, tileDay.Day))
                {
                    Label label = new Label();
                    label.Text = $"Title: {apt.title}. \nCustomer: {apt.contact}. \nTime: {apt.start.ToString("hh:mm")}";
                    label.Font = new Font("Microsoft Sans Serif", 10);
                    label.Width = 145;
                    label.Height = 80;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    
                    appointments_controlbox.Controls.Add(label);
                }
            }
        }

        private void WeeklyCalendarTile_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.ActiveCaption;
        }

        private void WeeklyCalendarTile_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlLight;
        }

        private void appointments_controlbox_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.ActiveCaption;
        }

        private void appointments_controlbox_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlLight;
        }
    }
}

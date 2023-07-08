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
    public partial class ReportForm : Form
    {
        List<string> types = new List<string>();
        List<UniqueType> typeList = new List<UniqueType>();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            //Generate the first type of report on load and ensure that the corresponding radio button is selected
            PopulateUniqueAppointments();
            uniqueAppointments_radioButton.Select();
        }

        private void PopulateUniqueAppointments()
        {
            //Clear DGView to ensure a fresh table
            reportDG.Rows.Clear();
            reportDG.Columns.Clear();

            //Set the widths and heights of the window, as well as the DGview and groupbox
            this.Width = 670;
            this.Height = 642;
            eventGroupBox.Width = 630;
            eventGroupBox.Height = 382;
            reportDG.Width = 618;
            reportDG.Height = 353;

            //Set template for columns and widths for stylizing purposes
            reportDG.Columns.Add("month", "Month");
            reportDG.Columns.Add("aptName", "Type");
            reportDG.Columns.Add("typeCount", "Occurences");
            reportDG.Columns[0].Width = 205;
            reportDG.Columns[1].Width = 205;
            reportDG.Columns[2].Width = 205;


            //Populate appointments to ensure no null values and a fully updated list
            DBTables.PopulateAppointments();
            for (int i = 0; i < 12; i++)
            {
                string month;
                for (int j = 0; j < DBTables.AppointmentList.Count; j++)
                {
                    //Iterate through each appointment and see if the month is equal to I and see if the types list already has that type
                    if (DBTables.AppointmentList[j].start.Month == i + 1 && !types.Contains(DBTables.AppointmentList[j].type))
                    {
                        //Add the type string to the types list for future comparisons and create an entry to keep track of number of occurrences
                        types.Add(DBTables.AppointmentList[j].type);
                        UniqueType apt = new UniqueType(i, DBTables.AppointmentList[j].type);
                        typeList.Add(apt);

                    }
                    //If the current appointment DOES match an entry in the unique list, increase the number of occurences before adding them.
                    else if(DBTables.AppointmentList[j].start.Month == i + 1 && types.Contains(DBTables.AppointmentList[j].type))
                    {
                        foreach(UniqueType item in typeList)
                        {
                            if(item.typeName == DBTables.AppointmentList[j].type)
                            {
                                item.numApts++;
                            }
                        }
                    }
                }

                //Set the month and add unique types with their nums of occurences
                month = new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMMM");
                foreach (var entry in typeList)
                {
                    //Add the month and names + occurences to the DGView
                    reportDG.Rows.Add(month, entry.typeName, entry.numApts);
                }

                //Clear both lists before starting the next iteration for the next month
                types.Clear();
                typeList.Clear();
            }
        }

        private void consultantSchedule_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Populate appointment and user tables to ensure tables are not empty and have the most updated information.
            DBTables.PopulateAppointments();
            DBTables.PopulateUsersTable();

            //Clear DGView
            reportDG.Rows.Clear();
            reportDG.Columns.Clear();

            //Expand size of the windows and DGView to fit all information
            this.Width = 670;
            this.Height = 642;
            eventGroupBox.Width = 630;
            eventGroupBox.Height = 382;
            reportDG.Width = 618;
            reportDG.Height = 353;

            //Set template for consultant schedule report
            reportDG.Columns.Add("consultant", "Consultant");
            reportDG.Columns.Add("startTime", "Start Time");
            reportDG.Columns.Add("endTime", "End Time");
            reportDG.Columns[0].Width = 205;
            reportDG.Columns[1].Width = 205;
            reportDG.Columns[2].Width = 205;

            //Iterate through each user, and then each appointment to add every appointment by consultant.
            foreach (User user in DBTables.UserList)
            {
                foreach (Appointment appointment in DBTables.AppointmentList)
                {
                    if (appointment.userId == user.userId)
                    {
                        //Add the corresponding user as well as the appointments start and end times to map each consultants schedule
                        reportDG.Rows.Add(user.username, appointment.start.ToString("MM-dd-yyyy hh:mm"), appointment.end.ToString("MM-dd-yyyy hh:mm"));
                    }
                }
            }
            //Sort by time, so everything is listed chronologically, then sort by consultant, so each consultant is shown in clusters.
            reportDG.Sort(reportDG.Columns["startTime"], ListSortDirection.Ascending);
            reportDG.Sort(reportDG.Columns["consultant"], ListSortDirection.Ascending);
        }

        private void uniqueAppointments_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateUniqueAppointments();
        }

        private void customerAppointments_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Populate tables to get an updated and full list of customer and appointemnts.
            DBTables.PopulateAppointments();
            DBTables.PopulateCustomerList();

            //Clear DGView for fresh template
            reportDG.Rows.Clear();
            reportDG.Columns.Clear();

            //Set the widths and heights of the window, as well as the DGview and groupbox
            this.Width = 465;
            this.Height = 642;
            eventGroupBox.Width = 425;
            eventGroupBox.Height = 382;
            reportDG.Width = 413;
            reportDG.Height = 353;

            //Set template for columns and widths for stylizing purposes
            reportDG.Columns.Add("customer", "Customer Name");
            reportDG.Columns.Add("numApts", "Appointments");
            reportDG.Columns[0].Width = 205;
            reportDG.Columns[1].Width = 205;

            //Iterate through each appointment and customer to add DGView of each customer with their appointment count
            foreach (Customer customer in DBTables.CustomerList)
            {
                int customerCount = 0;
                foreach (Appointment appointment in DBTables.AppointmentList)
                {
                    if (appointment.customerId == customer.customerId)
                    {
                        customerCount++;
                    }
                }
                reportDG.Rows.Add(customer.customerName, customerCount);
            }
        }
    }

    public class UniqueType
    {
        public int monthNum { get; set; }
        public string typeName { get; set; }
        public int numApts { get; set; }

        public UniqueType(int month, string type)
        {
            this.monthNum = month;
            this.typeName = type;
            this.numApts = 1;
    }
    }
}

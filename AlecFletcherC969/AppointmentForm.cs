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
    public partial class AppointmentForm : Form
    {
        Appointment apt = new Appointment();
        public DateTime businessStart = new DateTime();
        public DateTime businessEnd = new DateTime();

        /*
         Shortens code from: 
            if(start < businessStart)
            {
                MessageBox.Show($"Meeting is {}");
                return false;
            }
            if (end > businessEnd)
            {
                MessageBox.Show($"Meeting ends after business hours. \nBusiness Hours are Monday - Friday, {businessStart.ToString("hh:mm tt")} - {businessEnd.ToString("hh:mm tt")}");
                return false;
            }

        Down to:
            if (start < businessStart || end > businessEnd)
            {
                MessageBox.Show("Meeting " + (beforeOrAfter(start, businessStart) ? "starts before " : "ends after") + $"business hours. \nBusiness Hours are Monday - Friday, {businessStart.ToString("hh: mm tt")} - {businessEnd.ToString("hh: mm tt")}");
                return false;
            }
        LAMBDA 1 */
        delegate bool isBeforeOrAfter(DateTime aptStart, DateTime businessStart);
        isBeforeOrAfter beforeOrAfter = (start, bizStart) => start < bizStart;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(Appointment appointment)
        {
            InitializeComponent();
            apt = appointment;

            DataTable table = new DataTable();
            PopulateTable(table);
            customerDG.DataSource = table;

            title_textbox.Text = apt.title;
            contact_textbox.Text = apt.contact;
            type_textbox.Text = apt.type;
            location_textbox.Text = apt.location;
            url_textbox.Text = apt.url;
            description_textbox.Text = apt.description;
            startDate_timePicker.Value = apt.start.ToLocalTime();
            endDate_timePicker.Value = apt.end.ToLocalTime();

            //Set width to make it more visually appealing
            customerDG.Columns[1].Width = 128;
            customerDG.Columns[2].Width = 130;
            customerDG.Columns[4].Width = 70;
            customerDG.Columns[3].Width = 70;
            customerDG.Columns[5].Width = 50;
            endDate_timePicker.Format = DateTimePickerFormat.Custom;
            endDate_timePicker.CustomFormat = " MM / dd | hh:mm tt";
            startDate_timePicker.Format = DateTimePickerFormat.Custom;
            startDate_timePicker.CustomFormat = " MM / dd | hh:mm tt";

            addAppointment_button.Text = "Modify Appointment";
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            //Populate the datagrid with customer information to assign the active customer for the appointment
            DataTable table = new DataTable();
            PopulateTable(table);
            customerDG.DataSource = table;

            //Assign header text 
            customerDG.Columns[0].Visible = false;
            customerDG.Columns[1].HeaderText = "Name";
            customerDG.Columns[2].HeaderText = "Address";
            customerDG.Columns[3].HeaderText = "Address 2";
            customerDG.Columns[4].HeaderText = "City";
            customerDG.Columns[5].HeaderText = "Postal Code";
            customerDG.Columns[6].HeaderText = "Country";
            customerDG.Columns[7].HeaderText = "Phone Number";

            //Set width to make it more visually appealing and change time format to make it easier to read
            customerDG.Columns[1].Width = 128;
            customerDG.Columns[2].Width = 130;
            customerDG.Columns[4].Width = 70;
            customerDG.Columns[3].Width = 70;
            customerDG.Columns[5].Width = 50;
            endDate_timePicker.Format = DateTimePickerFormat.Custom;
            endDate_timePicker.CustomFormat = " MM / dd | hh:mm tt";
            startDate_timePicker.Format = DateTimePickerFormat.Custom;
            startDate_timePicker.CustomFormat = " MM / dd | hh:mm tt";

        }

        //Function to assign a query of customer information to a DataTable
        public DataTable PopulateTable(DataTable dt)
        {
            string fillCustomerTable = "SELECT customer.customerId, customer.customerName, address.address, address.address2," +
            " city.city, address.postalCode, country.country, address.phone FROM customer " +
            "INNER JOIN  address ON address.addressId = customer.addressId " +
            "INNER JOIN city ON city.cityId = address.cityId " +
            "INNER JOIN country ON city.countryId = country.countryId " +
            "ORDER BY customer.customerName;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(fillCustomerTable, DBConnection.conn);
            dt.Clear();
            adapter.Fill(dt);
            return dt;
        }

        private void addAppointment_button_Click(object sender, EventArgs e)
        {
            DateTime startOfApt = (DateTime)startDate_timePicker.Value;
            DateTime endOfApt = (DateTime)endDate_timePicker.Value;

            //Set business hours of 7AM - 6PM local time
            DateTime businessStart = new DateTime(startOfApt.Year, startOfApt.Month, startOfApt.Day, 7, 0, 0);
            DateTime businessEnd = new DateTime(startOfApt.Year, startOfApt.Month, startOfApt.Day, 18, 0, 0);

            if (IsInBusinessHours(startOfApt, endOfApt, businessStart, businessEnd))
            {
                if(this.Text == "Add Appointment")
                {
                    apt.appointmentId = DBTables.GetNewAppointmentID();
                }
                if(DoesNotOverlap(startOfApt, endOfApt, apt.appointmentId))
                {
                    apt.customerId = (int)customerDG.SelectedRows[0].Cells[0].Value;
                    apt.userId = HomeForm.userId;
                    if (title_textbox.Text == "") { apt.title = "not needed"; } else { apt.title = title_textbox.Text; }
                    if (description_textbox.Text == "") { apt.description = "not needed"; } else { apt.description = description_textbox.Text; }
                    if (location_textbox.Text == "") { apt.location = "not needed"; } else { apt.location = location_textbox.Text; }
                    if (contact_textbox.Text == "") { apt.contact = "not needed"; } else { apt.contact = contact_textbox.Text; }
                    if (type_textbox.Text == "") { apt.type = "not needed"; } else { apt.type = type_textbox.Text; }
                    if (url_textbox.Text == "") { apt.url = "not needed"; } else { apt.url = url_textbox.Text; }
                    apt.start = (DateTime)startDate_timePicker.Value.AddSeconds(-startDate_timePicker.Value.Second).ToUniversalTime();
                    apt.end = (DateTime)endDate_timePicker.Value.AddSeconds(-endDate_timePicker.Value.Second).ToUniversalTime();
                    apt.createDate = DateTime.Parse(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    apt.createdBy = HomeForm.user;
                    apt.lastUpdate = DateTime.Parse(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
                    apt.lastUpdatedBy = HomeForm.user;

                    if (this.Text == "Add Appointment")
                    {
                        DBTables.AddAppointment(apt);
                        Writer.WriteAppointment(apt);
                    }
                    else if (this.Text == "Modify Appointment")
                    {
                        DBTables.UpdateAppointment(apt);
                        MessageBox.Show("Appointment Updated");
                    }
                    this.Close();

                }

            }

        }

        private bool IsInBusinessHours(DateTime start, DateTime end, DateTime businessStart, DateTime businessEnd)
        {
            //LAMBDA 1
            //If appointment is scheduled before or after business hours, throw an error message letting the user know that it's invalid
            if (start < businessStart || end > businessEnd)
            {
                MessageBox.Show("Meeting " + (beforeOrAfter(start, businessStart) ? "starts before " : "ends after ") + $"business hours. \nBusiness Hours are Monday - Friday, {businessStart.ToString("hh: mm tt")} - {businessEnd.ToString("hh: mm tt")}");
                return false;
            }
            //LAMBDA 1


            if (start > end)
            {
                MessageBox.Show("Apointment end is set before the start of your appointment.");
                return false;
            }
            if((int)start.DayOfWeek == 0 || (int)start.DayOfWeek == 6)
            {
                MessageBox.Show($"Appointment is scheduled on a weekend. \nBusiness Hours are Monday - Friday, {businessStart.ToString("hh:mm tt")} - {businessEnd.ToString("hh:mm tt")}");
                return false;
            }
            if(end.Day != start.Day)//Hours set for apt are greater than 8, throw an error
            {
                MessageBox.Show($"Appointment end needs to be on the same day as the start. \nBusiness Hours are Monday - Friday, {businessStart.ToString("hh:mm tt")} - {businessEnd.ToString("hh:mm tt")}");
                return false; 
            }
            return true;
        }

        public bool DoesNotOverlap(DateTime aptStart, DateTime aptEnd, int aptId)
        {
            DBTables.PopulateAppointments();
            foreach(var appointment in DBTables.AppointmentList)
            {
                if (aptId == appointment.appointmentId)
                {
                    
                }
                else if((aptStart >= appointment.start.ToLocalTime() && aptStart < appointment.end.ToLocalTime()) || (aptEnd >= appointment.start.ToLocalTime() && aptEnd < appointment.end.ToLocalTime()) || (aptStart < appointment.start.ToLocalTime() && aptEnd > appointment.end.ToLocalTime()))
                {
                    MessageBox.Show($"Appointment overlaps with appointment scheduled from {appointment.start.ToLocalTime().ToString("hh:mm tt")} - {appointment.end.ToLocalTime().ToString("hh:mm tt")}.");
                    return false;
                }
            }
            return true;
        }

        

        //After appointment form fully loads, checks if an appointment was passed. If it was, finds the customer with the customerId of passed appointment.
        private void AppointmentForm_Shown(object sender, EventArgs e)
        {
            if (this.Text == "Modify Appointment")
            {
                for (int i = 0; i < customerDG.RowCount; i++)
                {
                    if (Convert.ToInt32(customerDG.Rows[i].Cells[0].Value) == apt.customerId)
                    {
                        customerDG.Rows[i].Selected = true;
                        return;
                    }
                }
            }
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

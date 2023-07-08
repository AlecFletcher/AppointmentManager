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
    public partial class AppointmentListForm : Form
    {
        DataTable dt = new DataTable();
        DataTable clonedTable = new DataTable();
        public AppointmentListForm()
        {
            InitializeComponent();
        }

        private void AppointmentList_Load(object sender, EventArgs e)
        {            
            //Populate dg with list of all appointments
            PopulateTable();

            //Set column widths and header names for datagrid
            StylizeDG();
        }

        private void PopulateTable()
        {
            //Create custom query to show customer info with appointment info to fully judge which appointments may need to be modified or deleted
            DBTables.PopulateAppointments();
            string query = "SELECT " +
                "appointment.appointmentId, " +
                "customer.customerName, " +
                "appointment.start, " +
                "appointment.end, " +
                "appointment.title, " +
                "appointment.description, " +
                "appointment.location, " +
                "appointment.contact, " +
                "appointment.type, " +
                "appointment.url " +
                "FROM appointment " +
                "INNER JOIN customer WHERE appointment.customerId = customer.customerId " +
                "ORDER BY appointment.start";
            dt = DBTables.CustomQuery(query);

            //Clone the dt so we can set the data type of the DateTime columns and display them in a friendlier format
            clonedTable = dt.Clone();
            clonedTable.Columns[0].DataType = typeof(Int32);
            clonedTable.Columns[2].DataType = typeof(string);
            clonedTable.Columns[3].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                clonedTable.ImportRow(row);
            }
            
            //Set the time formats to the above stated friendly format
            foreach (DataRow row in clonedTable.Rows)
            {
                //Column 2 and 3
                DateTime start = DateTime.Parse(row[2].ToString());
                DateTime end = DateTime.Parse(row[3].ToString());
                row[2] = start.ToLocalTime().ToString("ddd, MMM dd hh:mm tt");
                row[3] = end.ToLocalTime().ToString("ddd, MMM dd hh:mm tt");
            }
            //Set the data source to the cloned table
            appointmentDG.DataSource = clonedTable;

        }

        //Helper function to style the datagrid with custom widths and proper header text
        private void StylizeDG()
        {
            appointmentDG.Columns[0].Visible = false;
            appointmentDG.Columns[1].Width = 110;
            appointmentDG.Columns[2].Width = 130;
            appointmentDG.Columns[3].Width = 130;

            appointmentDG.Columns[1].HeaderText = "Customer Name";
            appointmentDG.Columns[2].HeaderText = "Start Date / Time";
            appointmentDG.Columns[3].HeaderText = "End Date / Time";
            appointmentDG.Columns[4].HeaderText = "Title";
            appointmentDG.Columns[5].HeaderText = "Description";
            appointmentDG.Columns[6].HeaderText = "Location";
            appointmentDG.Columns[7].HeaderText = "Contact";
            appointmentDG.Columns[8].HeaderText = "Type";
            appointmentDG.Columns[9].HeaderText = "URL";

        }

        //Create instance of AppointmentForm with a passed appointment to populate the fields for editing
        private void modifyAppointment_button_Click(object sender, EventArgs e)
        {
            Appointment apt = DBTables.FindAppointment(Convert.ToInt32(appointmentDG.SelectedRows[0].Cells[0].Value));
            AppointmentForm aptForm = new AppointmentForm(apt);
            aptForm.Text = "Modify Appointment";
            aptForm.ShowDialog();
            PopulateTable();
        }

        //Cancel button. Closes the window
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Deletes appointment after giving a pop-up prompt ensuring that they do wish to delete the appointment.
        private void deleteAppointment_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Are you sure you want to delete this appointment?", "Delete Appointment?", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM appointment WHERE appointmentId = " + appointmentDG.SelectedRows[0].Cells[0].Value;
                DBTables.NonQueryCommand(query);
                MessageBox.Show("Appointment Deleted.");
                PopulateTable();
            }
            else { 
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }
    }
}

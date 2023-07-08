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
    public partial class CustomerListForm : Form
    {
        DataTable dataTable = new DataTable();
        DataTable dt = new DataTable();
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            //Query to fill dataGrid with specified dataTable
            dataTable = PopulateTable(dataTable);
            customerDG.DataSource = dataTable;

            //Assign header text 
            customerDG.Columns[0].Visible = false;
            customerDG.Columns[1].HeaderText = "Name";
            customerDG.Columns[2].HeaderText = "Address";
            customerDG.Columns[3].HeaderText = "Address 2";
            customerDG.Columns[4].HeaderText = "City";
            customerDG.Columns[5].HeaderText = "Postal Code";
            customerDG.Columns[6].HeaderText = "Country";
            customerDG.Columns[7].HeaderText = "Phone Number";

            //Set width to make it more visually appealing
            customerDG.Columns[2].Width = 130;
            customerDG.Columns[3].Width = 70;

        }

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

        private void modify_button_Click(object sender, EventArgs e)
        {
            Customer cust = DBTables.FindCustomer((int)customerDG.SelectedRows[0].Cells[0].Value);
            Address address = DBTables.FindAddress(cust.addressId);
            City city = DBTables.FindCity(address.cityId);
            Country country = DBTables.FindCountry(city.countryId);

            CustomerForm modifyForm = new CustomerForm(cust, address, city, country);
            modifyForm.ShowDialog();
            dataTable = PopulateTable(dataTable);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //Checks if customer has any appointments associated with them before deleting and disallows if they do
            int numApts = DBTables.NumAppointmentsForCustomer((int)customerDG.SelectedRows[0].Cells[0].Value);
            if (numApts > 0)
            {
                MessageBox.Show($"Can not delete customer. Customer has {numApts} appointment(s).");
                return;
            }
            else
            {
                //Finds the id's of the customer and all associated tables for deletion
                Customer cust = DBTables.FindCustomer((int)customerDG.SelectedRows[0].Cells[0].Value);
                Address address = DBTables.FindAddress(cust.addressId);
                City city = DBTables.FindCity(address.cityId);
                Country country = DBTables.FindCountry(city.countryId);

                //Give the user a dialog and confirm whether or not they wish to delete the customer.
                DialogResult dialog = MessageBox.Show($"Are you sure you want to delete {cust.customerName}?", "Delete Customer?", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    //Delete customer and all associated values in other tables
                    DBTables.DeleteCustomer(cust, address, city, country);
                    dataTable = PopulateTable(dataTable);
                }
                else if(dialog == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            //Maybe delete?
        }
    }
}

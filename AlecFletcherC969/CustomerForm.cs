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
    public partial class CustomerForm : Form
    {
        Customer passedCustomer;
        Address passedAddress;
        City passedCity;
        Country passedCountry;
        public CustomerForm()
        {
            InitializeComponent();
        }

        //Constructor for when modifying customer form
        public CustomerForm(Customer customer, Address address, City city, Country country)
        {
            InitializeComponent();
            customerName_textbox.Text = customer.customerName;
            address1_textbox.Text = address.address;
            address2_textbox.Text = address.address2;
            phone_textbox.Text = address.phone;
            city_textbox.Text = city.city;
            postalCode_textbox.Text = address.postalCode;
            country_textbox.Text = country.country;

            passedCustomer = customer;
            passedAddress = address;
            passedCity = city;
            passedCountry = country;

            this.Text = "Update Customer";
            submit_button.Text = "Update Customer";
        }

        //Checks whether any fields are blank or invalid
        private bool IsReadyToSubmit()
        {
                //Check if customer name is blank
                if (customerName_textbox.Text.Replace(" ", "").Length == 0)
                {
                    MessageBox.Show("Customer name is invalid.");
                    return false;
                }

                //Check if address is blank
                if (address1_textbox.Text.Replace(" ", "").Length == 0)
                {
                    MessageBox.Show("Customer address is invalid.");
                    return false;
                }

                //Check if phone number is a number
                if(phone_textbox.Text.Replace(" ", "").Length == 0)
                {
                    MessageBox.Show("Customer phone number is invalid.");
                    return false;
                }

                //Check if city is blank
                if (city_textbox.Text.Replace(" ", "").Length == 0)
                {
                    MessageBox.Show("Customer city is invalid.");
                    return false;
                }

                //Check if postal code is blank
                if (postalCode_textbox.Text.Replace(" ", "").Length == 0)
                {
                    MessageBox.Show("Customer postal code is invalid.");
                    return false;
                }

                //Check if country is blank
                if (country_textbox.Text.Replace(" ", "").Length == 0)
                {
                    MessageBox.Show("Customer country is invalid.");
                    return false;
                }
            return true;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (IsReadyToSubmit())
            {
                //If customer is being modified, run an update query for the customer and associated values in other tables
                if (this.Text == "Update Customer")
                {
                    string updateCustomer = $"UPDATE customer SET " +
                        $"customerName = '{customerName_textbox.Text}', " +
                        $"lastUpdate = '{DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                        $"lastUpdateBy = '{HomeForm.user}' " +
                        $"WHERE customerId = {passedCustomer.customerId}";

                    string updateAddress = $"UPDATE address SET " +
                        $"address = '{address1_textbox.Text}', " +
                        $"address2 = '{address2_textbox.Text}', " +
                        $"postalCode = '{postalCode_textbox.Text}', " +
                        $"phone = '{phone_textbox.Text}', " +
                        $"lastUpdate = '{DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss")}'," +
                        $" lastUpdateBy = '{HomeForm.user}' " +
                        $"WHERE addressId = {passedAddress.addressId}";

                    string updateCity = $"UPDATE city SET " +
                        $"city = '{city_textbox.Text}', " +
                        $"lastUpdate = '{DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                        $"lastUpdateBy = '{HomeForm.user}' " +
                        $"WHERE cityId = {passedCity.cityId}";

                    string updateCountry = $"UPDATE country SET " +
                        $"country = '{country_textbox.Text}', " +
                        $"lastUpdate = '{DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                        $"lastUpdateBy = '{HomeForm.user}' " +
                        $"WHERE countryId = {passedCountry.countryId}";

                        DBTables.NonQueryCommand(updateCustomer);
                        DBTables.NonQueryCommand(updateAddress);
                        DBTables.NonQueryCommand(updateCity);
                        DBTables.NonQueryCommand(updateCountry);
                        DBTables.PopulateCustomerList();
                        this.Close();

                }
                else
                //Or else, customer is being added, therefore run an Insert query for the customer and associated values in other tables.
                {
                    //Create country;
                    Country country = new Country();
                    country.countryId = DBTables.GetNewCountryID();
                    country.country = country_textbox.Text;
                    country.createDate = DateTime.UtcNow;
                    country.createdBy = HomeForm.user;
                    country.lastUpdate = DateTime.UtcNow;
                    country.lastUpdateBy = HomeForm.user;

                    //Create city
                    City city = new City();
                    city.cityId = DBTables.GetNewCityID();
                    city.city = city_textbox.Text;
                    city.countryId = country.countryId;
                    city.createDate = DateTime.UtcNow;
                    city.createdBy = HomeForm.user;
                    city.lastUpdate = DateTime.UtcNow;
                    city.lastUpdateBy = HomeForm.user;

                    //Create new address
                    Address address = new Address();
                    address.addressId = DBTables.GetNewAddressID();
                    address.address = address1_textbox.Text;
                    address.address2 = address2_textbox.Text;
                    address.cityId = city.cityId;
                    address.postalCode = postalCode_textbox.Text;
                    address.phone = phone_textbox.Text;
                    address.createDate = DateTime.UtcNow;
                    address.createdBy = HomeForm.user;
                    address.lastUpdate = DateTime.UtcNow;
                    address.lastUpdateBy = HomeForm.user;

                    //Create customer
                    Customer customer = new Customer();
                    customer.customerId = DBTables.GetNewCustomerID();
                    customer.customerName = customerName_textbox.Text;
                    customer.addressId = address.addressId;
                    customer.active = 1;
                    customer.createDate = DateTime.UtcNow;
                    customer.createdBy = HomeForm.user;
                    customer.lastUpdate = DateTime.UtcNow;
                    customer.lastUpdateBy = HomeForm.user;

                    try
                    {
                        //Add customer and associated values, then update the log with all the updated information
                        DBTables.AddCustomer(address, customer, city, country);
                        Writer.WriteCountry(country);
                        Writer.WriteCity(city);
                        Writer.WriteAddress(address);
                        Writer.WriteCustomer(customer);
                        this.Close();
                    }

                    //Catches mysql exception, like postal code being too long for example
                    catch(MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    }

            }
            return;
        }
    }
}

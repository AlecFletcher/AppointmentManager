using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlecFletcherC969
{
    public static class DBTables
    {
        public static BindingList<Appointment> AppointmentList = new BindingList<Appointment>();
        public static BindingList<User> UserList = new BindingList<User>();
        public static BindingList<Customer> CustomerList = new BindingList<Customer>();
        public static BindingList<Address> AddressList = new BindingList<Address>();
        public static BindingList<City> CityList = new BindingList<City>();
        public static BindingList<Country> CountryList = new BindingList<Country>();


        //Helper to just pass a custom non-query commnand in other classes
        public static void NonQueryCommand(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        // ******************* APPOINTMENT HELPER FUNCTIONS ************************

        //Creates an Appointment object for each row in the DB and adds to the AppointmentList BindingList
        public static void PopulateAppointments()
        {
            AppointmentList.Clear();
            string query = "SELECT * FROM appointment";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Appointment apt = new Appointment();

                apt.appointmentId = Convert.ToInt32(reader[0]);
                apt.customerId = Convert.ToInt32(reader[1]);
                apt.userId = Convert.ToInt32(reader[2]);
                apt.title = reader[3].ToString();
                apt.description = reader[4].ToString();
                apt.location = reader[5].ToString();
                apt.contact = reader[6].ToString();
                apt.type = reader[7].ToString();
                apt.url = reader[8].ToString();
                apt.start = (DateTime) reader[9];
                apt.end = (DateTime) reader[10];
                apt.createDate = (DateTime) reader[11];
                apt.createdBy = reader[12].ToString();
                apt.lastUpdate = (DateTime) reader[13];
                apt.lastUpdatedBy = reader[14].ToString();

                AppointmentList.Add(apt);
            }
            reader.Close();
        }

        //Finds all appointments for a given customerId
        public static int NumAppointmentsForCustomer(int id)
        {
            int numAppointments = 0;
            PopulateAppointments();
            foreach(var apt in AppointmentList)
            {
                if(apt.customerId == id)
                {
                    numAppointments++;
                }
            }
            return numAppointments;
        }

        // Returns an int for a new appointment Id
        public static int GetNewAppointmentID()
        {
            string query = "SELECT MAX(appointmentId) AS LargestId FROM appointment";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            return (int)command.ExecuteScalar() + 1;
        }


        public static void AddAppointment(Appointment appointment)
        {
                string query = "INSERT INTO appointment VALUES(" +
                $"{appointment.appointmentId}, {appointment.customerId}, {appointment.userId}, '{appointment.title}', '{appointment.description}', '{appointment.location}', " +
                $"'{appointment.contact}', '{appointment.type}', '{appointment.url}', '{appointment.start.ToString("yyyy-MM-dd HH:mm:ss")}', '{appointment.end.ToString("yyyy-MM-dd HH:mm:ss")}', '{appointment.createDate.ToString("yyyy-MM-dd HH:mm:ss")}', '{appointment.createdBy}', " +
                $"'{appointment.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}', '{appointment.lastUpdatedBy}')";
            try
            {
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Appointment Added");
        }

        public static void UpdateAppointment(Appointment appointment)
        {
            string query = "UPDATE appointment SET " +
                $"customerId = {appointment.customerId}, " +
                $"title = '{appointment.title}', " +
                $"description = '{appointment.description}', " +
                $"location = '{appointment.location}', " +
                $"contact = '{appointment.contact}', " +
                $"type = '{appointment.type}', " +
                $"url = '{appointment.url}', " +
                $"start = '{appointment.start.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"end = '{appointment.end.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"lastUpdate = '{appointment.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"lastUpdateBy = '{appointment.lastUpdatedBy}' " +
                $"WHERE appointmentId = {appointment.appointmentId}";
            try
            {
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Appointment Updated");
        }

        public static Appointment FindAppointment(int id)
        {
            PopulateAppointments();
            foreach(var appointment in AppointmentList)
            {
                if(appointment.appointmentId == id)
                {
                    return appointment;
                }
            }
            return null;
        }


    //*********** USER HELPER FUNCTIONS ******************

    //Creates a User object for each entry in the DB and adds it to the UserList BindingList
    public static void PopulateUsersTable()
        {
            UserList.Clear();
            string query = "SELECT * FROM user";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Index as follows: 0-userId, 1-username, 2-password, 3-active, 4-createDate, 5-createdBy, 6-lastUpdate, 7-lastUpdateBy
                User user = new User();
                user.userId = Convert.ToInt32(reader[0]);
                user.username = reader[1].ToString();
                user.password = reader[2].ToString();
                UserList.Add(user);
            }
            reader.Close();
        }


    // *********** CUSTOMER HELPER FUNCTIONS ***************
    public static void PopulateCustomerList()
        {
            CustomerList.Clear();
            string query = "SELECT * FROM customer";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.customerId = Convert.ToInt32(reader[0]);
                customer.customerName = reader[1].ToString();
                customer.addressId = Convert.ToInt32(reader[2]);
                customer.active = Convert.ToInt32(reader[3]);
                customer.createDate = (DateTime)reader[4];
                customer.createdBy = reader[5].ToString();
                customer.lastUpdate = (DateTime)reader[6];
                customer.lastUpdateBy = reader[7].ToString();

                CustomerList.Add(customer);

            }
            reader.Close();
        }

        //Returns a new customerId for adding new customers
    public static int GetNewCustomerID()
        {
            string query = "SELECT MAX(customerId) AS LargestId FROM customer";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            return (int)command.ExecuteScalar() + 1;
        }


        //Adds customer to the database after doing a try-catch for any mysql errors
    public static void AddCustomer(Address address, Customer customer, City city, Country country)
        {
            List<string> queries = new List<string>();
            string insertAddress = $"INSERT INTO address VALUES({address.addressId}, '{address.address}', '{address.address2}', '{address.cityId}', " +
                $"'{address.postalCode}', '{address.phone}', '{address.createDate.ToString("yyyy-MM-dd hh:mm:ss")}', '{address.createdBy}'," +
                $" '{address.lastUpdate.ToString("yyyy-MM-dd hh:mm:ss")}', '{address.lastUpdateBy}')";

            string insertCustomer = $"INSERT INTO customer VALUES({customer.customerId}, '{customer.customerName}', {customer.addressId}, " +
                $"{customer.active}, '{customer.createDate.ToString("yyyy-MM-dd hh:mm:ss")}', '{customer.createdBy}', " +
                $"'{customer.lastUpdate.ToString("yyyy-MM-dd hh:mm:ss")}', '{customer.lastUpdateBy}')";

            string insertCity = $"INSERT INTO city VALUES({city.cityId}, '{city.city}', {city.countryId}, '{city.createDate.ToString("yyyy-MM-dd hh:mm:ss")}', '{city.createdBy}', " +
                $"'{city.lastUpdate.ToString("yyyy-MM-dd hh:mm:ss")}', '{city.lastUpdateBy}') ";


            string insertCountry = $"INSERT INTO country VALUES({country.countryId}, '{country.country}', '{country.createDate.ToString("yyyy-MM-dd hh:mm:ss")}', '{country.createdBy}', " +
                $"'{country.lastUpdate.ToString("yyyy-MM-dd hh:mm:ss")}', '{country.lastUpdateBy}')";

            queries.Add(insertCountry);
            queries.Add(insertCity);
            queries.Add(insertAddress);
            queries.Add(insertCustomer);

            foreach(var query in queries)
            {
                try {
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                command.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            MessageBox.Show("Customer Added.");
        }

        //Returns searched customer when given customerId
    public static Customer FindCustomer(int id)
        {
            PopulateCustomerList();
            foreach(var customer in CustomerList)
            {
                if(customer.customerId == id)
                {
                    return customer;
                }
            }
            return new Customer();
        }

        public static DataTable CustomQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnection.conn);
                adapter.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }




        //******************* COUNTRY HELPER FUNCTIONS ************************
        public static void PopulateCountryList()
        {
            try
            {
                CountryList.Clear();
                string query = "SELECT * FROM country";
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Country country = new Country();
                    country.countryId = Convert.ToInt32(reader[0]);
                    country.country = reader[1].ToString();
                    country.createDate = (DateTime)reader[2];
                    country.createdBy = reader[3].ToString();
                    country.lastUpdate = (DateTime)reader[4];
                    country.lastUpdateBy = reader[5].ToString();

                    CountryList.Add(country);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static Country FindCountry(int id)
        {
            PopulateCountryList();
            foreach(var country in CountryList)
            {
                if(country.countryId == id)
                {
                    return country;
                }
            }
            return new Country();
        }

    public static int GetNewCountryID()
    {
        string query = "SELECT MAX(countryId) AS LargestId FROM country";
        MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
        return (int)command.ExecuteScalar() + 1;

    }




    // ********** CITY HELPER FUNCTIONS ************
    public static void PopulateCityList()
        {
            try
            {
                CityList.Clear();
                string query = "SELECT * FROM city";
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    City city = new City();
                    city.cityId = Convert.ToInt32(reader[0]);
                    city.city = reader[1].ToString();
                    city.countryId = Convert.ToInt32(reader[2]);
                    city.createDate = (DateTime)reader[3];
                    city.createdBy = reader[4].ToString();
                    city.lastUpdate = (DateTime)reader[5];
                    city.lastUpdateBy = reader[6].ToString();

                    CityList.Add(city);
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }


        }

        public static int GetNewCityID()
        {
            string query = "SELECT MAX(cityId) AS LargestId FROM city";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            return (int)command.ExecuteScalar() + 1;

        }

        public static City FindCity(int id)
        {
            PopulateCityList();
            foreach(var city in CityList)
            {
                if(city.cityId == id)
                {
                    return city;
                }
            }
            return new City();
        }

        //************** ADDRESS HELPER FUNCTIONS ******************

        //Returns the highest id + 1 for a new and valid addressId
        public static int GetNewAddressID()
        {
            string query = "SELECT MAX(addressId) AS LargestId FROM address";
            MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
            return (int)command.ExecuteScalar() + 1;
        }

        public static void PopulateAddressList()
        {
            try
            {
                CityList.Clear();
                string query = "SELECT * FROM address";
                MySqlCommand command = new MySqlCommand(query, DBConnection.conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Address address = new Address();
                    address.addressId = Convert.ToInt32(reader[0]);
                    address.address = reader[1].ToString();
                    address.address2 = reader[2].ToString();
                    address.cityId = Convert.ToInt32(reader[3]);
                    address.postalCode = reader[4].ToString();
                    address.phone = reader[5].ToString();
                    address.createDate = (DateTime)reader[6];
                    address.createdBy = reader[7].ToString();
                    address.lastUpdate = (DateTime)reader[8];
                    address.lastUpdateBy = reader[9].ToString();

                    AddressList.Add(address);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }


        }

        public static Address FindAddress(int id)
        {
            PopulateAddressList();
            foreach(var address in AddressList)
            {
                if(address.addressId == id)
                {
                    return address;
                }
            }
            return new Address();
        }

        public static void DeleteCustomer(Customer customer, Address address, City city, Country country)
        {
            string deleteCustomer = $"DELETE FROM customer WHERE customerId = {customer.customerId}";
            string deleteAddress = $"DELETE FROM address WHERE addressId = {address.addressId}";
            string deleteCity = $"DELETE FROM city WHERE cityId = {city.cityId}";
            string deleteCountry = $"DELETE FROM country WHERE countryId = {country.countryId}";

            NonQueryCommand(deleteCustomer);
            NonQueryCommand(deleteAddress);
            NonQueryCommand(deleteCity);
            NonQueryCommand(deleteCountry);

            MessageBox.Show("Customer successfully deleted.");
        }

    }



    public class Appointment
    {
        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }
    }

    public class CustomerInfo
    {
        int id { get; set; }
        string name { get; set; }
        string address1 { get; set; }
        string address2 { get; set; }
        string city { get; set; }
        string postalCode { get; set; }
        string country { get; set; }
        string phoneNumber { get; set; }

    }

    public class User
    {
        public int userId;
        public string username;
        public string password;
        public int active;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;
    }

    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public int active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }
    }

    public class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }
    }

    public class City
    {
        public int cityId;
        public string city;
        public int countryId;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;
    }

    public class Country
    {
        public int countryId;
        public string country;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;
    }
}

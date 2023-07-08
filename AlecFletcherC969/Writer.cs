using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlecFletcherC969
{
    public static class Writer
    {
        private static StreamWriter streamWriter;
        static string path = @".\log.txt";

        public static void WriteUserLogin(int id, string username)
        {
            string text = $"UserID: {id}, Username: {username} succesfully logged in at: {DateTime.UtcNow} UTC";
            if (File.Exists(path))
            {
                var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }

        }
        public static void WriteAppointment(Appointment appointment)
        {
            string text = $"User '{HomeForm.user}' added appointment ID: {appointment.appointmentId}. " +
       $"Customer ID: {appointment.customerId}. Title: {appointment.title}. User ID: {appointment.userId}. " +
       $"Description: {appointment.description}. Location: {appointment.location}. " +
       $"Contact: {appointment.contact}. Type: {appointment.type}. " +
       $"URL: {appointment.url}. Start: {appointment.start}. End: {appointment.end}. " +
       $"Create date: {appointment.createDate}";
            if (File.Exists(path))
            {
                var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }

        }

        public static void WriteCustomer(Customer customer)
        {
            string text = $"User '{HomeForm.user}' added customer ID: {customer.customerId}. " +
                $"Name: {customer.customerName}. AddressId: {customer.addressId}. Create date: {customer.createDate}";
            if (File.Exists(path))
            {
                var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
        }
        public static void WriteCity(City city)
        {
            string text = $"User '{HomeForm.user}' added city ID: {city.cityId}. " +
                $"City: {city.city}. Country ID: {city.countryId}. Create date: {city.createDate}";
            if (File.Exists(path))
            {
                var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
        }
        public static void WriteCountry(Country country)
        {
            string text = $"User '{HomeForm.user}' added country ID: {country.countryId} " +
                $"Country: {country.countryId}. Create date: {country.createDate}.";
            if (File.Exists(path))
            {
                var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
        }
        public static void WriteAddress(Address address)
        {
            string text = $"User '{HomeForm.user}' added address ID: {address.addressId}. " +
                $"Address: {address.address}. Address 2: {address.address2}. City ID: {address.cityId}. " +
                $"Postal Code: {address.postalCode}. Phone: {address.phone}. Create date: {address.createDate}.";
            if (File.Exists(path))
            {
                var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
            else
            {
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(text);
                streamWriter?.Close();
            }
        }
    }
}

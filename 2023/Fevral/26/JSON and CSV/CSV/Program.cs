using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comma Seperated Variables
            /*
             CSV example:
             Id, Name, Surname, Email
             1, Orkhan, Farajov, orkhankhf@gmail.com
             */
            #region Export Customers to CSV
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 200; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.Name = FakeData.NameData.GetFirstName();
                customer.Surname = FakeData.NameData.GetSurname();
                customer.Email = $"{customer.Name}.{customer.Surname}@{FakeData.NetworkData.GetDomain()}";
                customer.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();

                customers.Add(customer);
            }

            if (!Directory.Exists(@"C:\\CSV"))
                Directory.CreateDirectory(@"C:\\CSV");

            if (!File.Exists(@"C:\\CSV\\Customers.csv"))
            {
                var file = File.Create(@"C:\\CSV\\Customers.csv");
                file.Close();
            }

            StreamWriter sw = new StreamWriter(@"C:\\CSV\\Customers.csv");

            CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(sw);

            var trCulture = CultureInfo.GetCultureInfo("tr-TR"); //Turkey
            var trDaysInYear = trCulture.Calendar.GetDaysInYear(2023);
            var trCalendarName = trCulture.DateTimeFormat.NativeCalendarName;
            var trCurrencySeparator = trCulture.NumberFormat.CurrencyDecimalSeparator;
            var trFirstDayOfWeek = trCulture.DateTimeFormat.FirstDayOfWeek;
            var trEnglishName = trCulture.EnglishName;
            var trNativeName = trCulture.NativeName;


            var irCulture = CultureInfo.GetCultureInfo("fa-IR"); //Turkey
            var irDaysInYear = irCulture.Calendar.GetDaysInYear(2023);
            var irCalendarName = irCulture.DateTimeFormat.NativeCalendarName;
            var irCurrencySeparator = irCulture.NumberFormat.CurrencyDecimalSeparator;
            var irFirstDayOfWeek = irCulture.DateTimeFormat.FirstDayOfWeek;
            var irEnglishName = irCulture.EnglishName;
            var irNativeName = irCulture.NativeName;

            write.WriteHeader(typeof(Customer));

            foreach (var item in customers)
            {
                write.WriteRecord(item);
            }

            sw.Close();

            Console.WriteLine("Melumatlar CSV faylina elave olundu.");
            #endregion


            #region Import Customers from CSV
            StreamReader sr = new StreamReader(@"C:\\CSV\\Customers.csv");

            CsvHelper.CsvReader reader = new CsvHelper.CsvReader(sr);

            List<Customer> readCustomers = reader.GetRecords<Customer>().ToList();
            #endregion

        }
    }
}

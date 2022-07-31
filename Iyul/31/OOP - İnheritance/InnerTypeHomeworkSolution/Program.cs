using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomeworkSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 455545,
                BirthDate = new DateTime(1995, 12, 24),
                CreateDate = DateTime.Now,
                EditDate = null
            };

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                CreateDate = DateTime.Now,
                Country = country
            };

            Order laptopOrder = new Order()
            {
                Id = 2,
                OrderDetails = "Asus Tuf fx705gm, 3800",
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "MyBuilding",
                Street = "HomeStreet",
                Distinct = "Nerimanov",
                CreateDate = DateTime.Now,
                City = city
            };

            customer.Addresses[1] = new Address()
            {
                Id = 2,
                No = 40,
                Building = "Residance",
                Street = "WorkStreet",
                Distinct = "Yasamal",
                CreateDate = DateTime.Now,
                City = city
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 1,
                OrderDetails = "Samsung Galaxy S9+, 500usd",
                ShippingAddress = customer.Addresses[0],
                CreateDate = DateTime.Now,
                EditDate = new DateTime(2021, 12, 12)
            };

            laptopOrder.ShippingAddress = customer.Addresses[1];
            customer.Orders[1] = laptopOrder;

            customer.ShowAllInfo();
            Console.ReadLine();
            #endregion
        }
    }
}

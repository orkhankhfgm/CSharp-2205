using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Homework_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Email = "orkhankhf@gmail.com",
                Username = "orkhankhf",
                Password = "orxanDDD1"
            };
            Customer.AddCustomer(customer1);

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Elvin",
                Surname = "Jafarov",
                Email = "elvin@gmail.com",
                Username = "elvinj",
                Password = "elvinDDD1"
            };
            Customer.AddCustomer(customer2);

            Customer customer2Duplicate = new Customer()
            {
                Id = 2,
                Name = "Elvin",
                Surname = "Jafarov",
                Email = "elvin@gmail.com",
                Username = "elvinj",
                Password = "e2"
            };
            Customer.AddCustomer(customer2Duplicate);
        }
    }
}

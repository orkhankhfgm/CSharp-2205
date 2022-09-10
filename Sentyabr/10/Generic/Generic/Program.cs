using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is NOT Generic class
            Customer customer = new Customer();

            //GenericCustomer genericClass = new GenericCustomer();

            GenericCustomer<string> gCustomer = new GenericCustomer<string>();
            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);
            gCustomer.DocumentSerial = "AA";
            gCustomer.DocumentNo = "123456";
            gCustomer.PlaceOfBirth = "Baku";


            MultipleGenericClass<string, int, DateTime> multiGeneric = new MultipleGenericClass<string, int, DateTime>();
            multiGeneric.Id = 1;
            multiGeneric.Name = "Orkhan";
            multiGeneric.Surname = "Farajov";
            multiGeneric.DateOfBirth = new DateTime(1995, 12, 24);

            string name = multiGeneric.GetName();
            #endregion

            #region What is Generic Class
            /*
             Database     |     APP
             MsSQL        |     C#
             */

            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            List<Customer> customers = customerRepository.Get();

            GenericRepository<Item> itemRepository = new GenericRepository<Item>();
            List<Item> items = itemRepository.Get();

            Customer cust = new Customer();
            Item item = new Item();

            customerRepository.Add(cust);
            itemRepository.Add(item);
            #endregion
        }
    }
}

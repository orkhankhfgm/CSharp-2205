using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomeworkSolution
{
    public class Customer
    {
        /*
            Homework 1:
            Customer içində inner type olaraq yazacağınız array'lardakı dataları göstərən bir neçə methodunuz olacaq. Həmin method'lar
            Customer'in öz məlumatlarını, Order'lərini, Contact'larını, Address'lərini və s. göstərəcək. Main method'unda yaradacağınız
            customer instance'ının vasitəsilə həm ayrı-ayrılıqda Contact, Address və s., həm də bütün məlumatları da görmək olsun.
            Bütün məlumatlar dedikdə yəni, customer.ShowAllInfo() method'u bütün məlumatları çıxardacaq və ya customer.ShowAddresses()
            isə sadəcə ünvan məlumatlarını göstərəcək. Ünvan məlumatlarında nəzərə alın ki, inner type olan'ların da property'ləri 
            ekrana yazdırılsın. Əgər EditDate null olarsa, o zaman "Data is not edited" olmazsa da editlənmə tarixi 12.12.2022 formatla
            göstərilsin.

            Məsələn Contact üzərindən bir nümunə verim.
            customer.ShowContacts() method'u ekrana bu şəkildə çıxmalıdır:
            Id: 1
            Email: orkhankhf@gmail.com
            PhoneNumber: +994555810872
            CreateDate: 12.12.2014
            EditDate: Data is not edited

            (əgər 2-ci Contact varsa aşağıdakı da çıxsın)
            Id: 2
            Email: test@gmail.com
            PhoneNumber: +994551231212
            CreateDate: 12.12.2015
            EditDate: 12.12.2018
        */

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        #region Inner Type required fields
        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;
        #endregion

        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }

        public void ShowCustomerInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("DocumentNo: {0}", DocumentNo);
            Console.WriteLine("BirthDate: {0}", BirthDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("CreateDate: {0}", CreateDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("EditDate: {0}", EditDate.HasValue ? EditDate.Value.ToString("dd.MM.yyyy") : "Data is not edited");
        }

        public void ShowContacts()
        {
            foreach (var item in Contacts)
            {

                if (item != null)
                {
                    Console.WriteLine("Id: {0}", item.Id);
                    Console.WriteLine("Email: {0}", item.Email);
                    Console.WriteLine("PhoneNumber: {0}", item.PhoneNumber);
                    Console.WriteLine("CreateDate: {0}", item.CreateDate.ToString("dd.MM.yyyy"));
                    Console.WriteLine("EditDate: {0}", item.EditDate.HasValue ? item.EditDate.Value.ToString("dd.MM.yyyy") : "Data is not edited");//shorthand if else

                    //if(item.EditDate.HasValue)
                    //    Console.WriteLine("EditDate: {0}", item.EditDate.Value.ToString("dd.mm.yyyy"));
                    //else
                    //    Console.WriteLine("EditDate: {0}", "Data is not edited");
                }
            }
        }

        public void ShowAddresses()
        {
            foreach (var item in Addresses)
            {
                if(item != null)
                {
                    Console.WriteLine("Id: {0}", item.Id);
                    Console.WriteLine("Address: {0}, {1}, {2}, {3}, {4}, {5}",
                        item.City.Country.Name,
                        item.City.Name,
                        item.Distinct,
                        item.Street,
                        item.Building,
                        item.No);
                    Console.WriteLine("CreateDate: {0}", item.CreateDate.ToString("dd.MM.yyyy"));
                    Console.WriteLine("EditDate: {0}", item.EditDate.HasValue ? item.EditDate.Value.ToString("dd.MM.yyyy") : "Data is not edited");
                }
            }
        }

        public void ShowOrders()
        {
            foreach (var item in Orders)
            {
                if(item != null)
                {
                    Console.WriteLine("Id: {0}", item.Id);
                    Console.WriteLine("Order Details: {0}", item.OrderDetails);
                    Console.WriteLine("Address: {0}, {1}, {2}, {3}, {4}, {5}",
                        item.ShippingAddress.City.Country.Name,
                        item.ShippingAddress.City.Name,
                        item.ShippingAddress.Distinct,
                        item.ShippingAddress.Street,
                        item.ShippingAddress.Building,
                        item.ShippingAddress.No);
                    Console.WriteLine("CreateDate: {0}", item.CreateDate.ToString("dd.MM.yyyy"));
                    Console.WriteLine("EditDate: {0}", item.EditDate.HasValue ? item.EditDate.Value.ToString("dd.MM.yyyy") : "Data is not edited");
                }
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine("---------------Customer Details---------------");
            ShowCustomerInfo();
            Console.WriteLine("---------------Contact Details---------------");
            ShowContacts();
            Console.WriteLine("---------------Address Details---------------");
            ShowAddresses();
            Console.WriteLine("---------------Order Details---------------");
            ShowOrders();
        }
    }
}

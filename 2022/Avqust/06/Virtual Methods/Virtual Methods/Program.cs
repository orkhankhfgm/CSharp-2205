using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General
            Customer customer = new Customer();
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            var tostring = customer.ToString();
            Console.WriteLine(tostring);
            #endregion


            #region Create and use virtual methods
            Item item = new Item();
            item.ShowText("ShowText called from Item");

            BaseClass bc = new BaseClass();
            bc.ShowText("ShowText called from BaseClass");

            item.ShowText("Hi!");
            #endregion
        }
    }
}

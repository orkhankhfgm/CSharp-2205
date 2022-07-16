using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            customer.Email = "orkhankhf@gmail.com";
            var test = customer.Email;


            Student student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf12345@gmail.com";
            var test2 = student.Email;


            int studentId = student.Id;
        }
    }
}

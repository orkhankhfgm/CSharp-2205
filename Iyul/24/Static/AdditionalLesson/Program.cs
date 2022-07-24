using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student orkhan = new Student();
            orkhan.Id = 1;
            orkhan.Name = "Orkhan";
            orkhan.Surname = "Farajov";
            orkhan.Email = "orkhankhf@gmail.com";
            orkhan.Gender = 1;
            Helper.ShowStudentInfo(orkhan);

            Student elcin = new Student();
            elcin.Id = 1;
            elcin.Name = "Elcin";
            elcin.Surname = "Piriyev";
            elcin.Email = "elcin@gmail.com";
            elcin.Gender = 1;
            Helper.ShowStudentInfo(elcin);

            Student pervin = new Student();
            pervin.Id = 1;
            pervin.Name = "Pervin";
            pervin.Surname = "Hesenov";
            pervin.Email = "pervin@gmail.com";
            pervin.Gender = 1;
            Helper.ShowStudentInfo(pervin);

            int orkhanId = 1;
            string orkhanName = "Orkhan";
            string orkhanSurname = "Farajov";
            string orkhanEmail = "orkhankhf@gmail.com";
            int orkhanGender = 1;
            Helper.ShowStudentInfo(orkhanId, orkhanName, orkhanSurname, orkhanEmail, orkhanGender);

            int elcinId = 1;
            string elcinName = "Elcin";
            string elcinSurname = "Piriyev";
            string elcinEmail = "elcin@gmail.com";
            int elcinGender = 1;
            Helper.ShowStudentInfo(elcinId, elcinName, elcinSurname, elcinEmail, elcinGender);

            int pervinId = 1;
            string pervinName = "Pervin";
            string pervinSurname = "Hesenov";
            string pervinEmail = "pervin@gmail.com";
            int pervinGender = 1;
            Helper.ShowStudentInfo(pervinId, pervinName, pervinEmail, pervinSurname, pervinGender);





            int testMethod = Helper.TestMethod(); //Test method'un icinde return olunan deyer testMethod deyiseninde saxlanilacaq.
            string testMethod1 = Helper.TestMethod1(); //Test method1'in icinde return olunan deyer testMethod1 deyiseninde saxlanilacaq.
            double testMethod2 = Helper.TestMethod2(); //Test method2'in icinde return olunan deyer testMethod2 deyiseninde saxlanilacaq.
            Console.WriteLine("Salam dunya!");
            //string name = Console.ReadLine();


            Student getFromDatabase = Helper.GetStudentFromDatabase();


            Helper helper = new Helper();
            Student getFromDatabase2 = helper.GetStudentFromDatabase2();
        }
    }
}

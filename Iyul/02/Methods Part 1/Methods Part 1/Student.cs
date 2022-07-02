using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_1
{
    public class Student
    {
        /*
         Method necə yazılır?
         [access modifier] [return type] [method name] ( parameters ){
             method'un body hissesi
         }



         Access Modifiers:
         1. Public
         Bir method'u public teyin etdiyimiz zaman biz eslinde deyirik ki, class'a eli catan her yerde bu methoddan istifade etmek olsun.

         2. Private
         Eger methodumuzu private teyin etsek o zaman bu method'a yalniz ve yalniz teyin etdiyimiz class daxilinden elimiz catacaq. Yeni class'in
         icinde private method teyin edende, bu method'u ancaq hemin classin icinden cagirmaq olur.
         Not: Class'larin ozunu private teyin ede bilmirik.

         3. Protected
         4. Internal
         5. Internal Protected
         */


        public void HelloStudent()
        {
            Console.WriteLine("Salam Telebe!");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1}", name, surname);
        }

        public void ShowHasanInfo()
        {
            ShowStudentInfo("Hesen", "Haciyev");
        }
    }
}

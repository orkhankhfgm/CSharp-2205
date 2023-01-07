using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Test()
        {
            Test1();
            Console.WriteLine("Bu method'u istifade etmek ucun Student class'inin instance'i yaradilmalidir!");
        }

        public static void Test1()
        {
            Console.WriteLine("Bu method'u istifade etmek ucun Student class'inin instance'i YARADILMAMALIDIR!");
        }
        //(Test() içində Test1()-i çağır)
        //(Test1() içində Test()-i çağır) //olmayacaq
    }
}

using System;

namespace Methods_Part_1_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty, surname = string.Empty;
            decimal p1 = 0, p2 = 0, p3 = 0, average = 0;

            Console.WriteLine("Zehmet olmasa telebe melumatlarini daxil edin.");

            Console.Write("Ad: ");
            name = Console.ReadLine();

            Console.Write("Soyad: ");
            surname = Console.ReadLine();

            Console.Write("Qiymet 1: ");
            p1 = decimal.Parse(Console.ReadLine());

            Console.Write("Qiymet 2: ");
            p2 = decimal.Parse(Console.ReadLine());

            Console.Write("Qiymet 3: ");
            p3 = decimal.Parse(Console.ReadLine());

            Student student = new Student();
            student.CalcAverage(name, surname, p1, p2, p3);

            Console.ReadLine();
        }
    }
}

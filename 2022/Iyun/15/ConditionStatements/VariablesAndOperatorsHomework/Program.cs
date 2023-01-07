using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperatorsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Homework
            int a, b, c;
            Console.WriteLine("1-ci reqem");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("2-ci reqem");
            b = int.Parse(Console.ReadLine());

            //1-ci yol
            //c = a;
            //a = b;
            //b = c;

            //2-ci yol
            a = a + b;
            b = a - b;
            a = a - b;


            //2. Homework
            int num1, num2, num3;

            Console.WriteLine("1-ci reqem:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2-ci reqem:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3-ci reqem:");
            num3 = Convert.ToInt32(Console.ReadLine());

            int res = num1 * num2 * num3;
            Console.WriteLine("Netice: " + num1 + " x " + num2 + " x " + num3 + " = " + res);


            //3. Homework
            int num4 = 0;
            Console.WriteLine("10 deyer daxil edin: ");
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());
            num4 += Convert.ToInt32(Console.ReadLine());

            num4--; //num4 = num4 - 1;
            Console.WriteLine("Netice: " + num4);
        }
    }
}

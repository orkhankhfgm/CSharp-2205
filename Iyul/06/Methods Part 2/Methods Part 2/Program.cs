using System;
using System.Linq;

namespace Methods_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default parameter values
            ShowDate(DateTime.Now.Day, DateTime.Now.Month);
            ShowDate(DateTime.Now.Day, DateTime.Now.Month, 2023);
            #endregion


            #region Ref and Out keywords
            int num1 = 50;//(stack'da yarandi)
            SetRef(ref num1); //(num1 deyeri 10 olacaq)

            //int num2 = 0; //(7.0-dan once bele yazilmali idi)
            int num2;
            SetOut(out num2);
            #endregion

            //Flexible (dəyişkən) sayda parametr ala bilmək
            Addition(15, 15, 15, 15, 20, 20);


            //Method Overloading
            AdditionNums(5, 10);
            AdditionNums(5, 10, 15);
            AdditionNums(15.5m, 20.5m);
            AdditionNums("5", "10");


            //Use method as parameter
            //uzun versiya
            decimal s = Subtraction(15.5M, 2.5M);
            ShowValue(s);

            //qisa versiya
            ShowValue(Subtraction(15.5M, 2.5M));

            Console.Clear();

            //Local functions
            AdditionWithLocalFunc(20, 15);
            SecondAdditionWithLocalFunc(10, 20, 30, 40);
            ThirdAdditionWithLocalFunc(10, 20, 30, 40);
        }

        public static void ShowDate(int day, int month, int year = 2022) //(year burda default value'sü olan parametr'dir.)
        {
            Console.WriteLine("Tarix: {0}.{1}.{2}", day, month, year);
        }

        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }

        #region Flexible (dəyişkən) sayda parametr ala bilmək
        static void Addition(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine("Toplam: {0}", total);

            //Qisa versiya
            Console.WriteLine("Toplam: {0}", numbers.Sum());
        }

        //(yanlis: (params int[] numbers, int a))
        //(dogru: (int a, params int[] numbers))
        #endregion

        #region Method Overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(int num1, int num2, int num3)
        {
            int total = num1 + num2 + num3;
            Console.WriteLine(total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(string num1, string num2)
        {
            decimal total = decimal.Parse(num1) + decimal.Parse(num2);
            Console.WriteLine(total);
        }
        #endregion


        #region Use method as parameter
        static void ShowValue(decimal obj)
        {
            Console.WriteLine(obj);
        }

        static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion


        #region Local functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int result = Addition(num1, num2);
            Console.WriteLine(result);
        }

        static void SecondAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int Addition(int num1Local, int num2Local)
            {
                int SecondAddition(int num3Local, int num4Local)
                {
                    return num3Local + num4Local;
                }

                int result = SecondAddition(num3, num4);

                return result + num1Local + num2Local;
            }

            int total = Addition(num1, num2);

            Console.WriteLine(total);
        }

        //(daha seliqeli versiya)
        static void ThirdAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int total = 0;

            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int SecondAddition(int num3Local, int num4Local)
            {
                return num3Local + num4Local;
            }

            total += Addition(num1, num2);
            total += SecondAddition(num3, num4);

            Console.WriteLine(total);
        }
        #endregion
    }
}

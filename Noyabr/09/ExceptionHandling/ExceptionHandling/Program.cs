using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Exception Handling?
            Console.WriteLine("Bid eded daxil edin: ");
            int outVal;

            int.TryParse(Console.ReadLine(), out outVal); //burda herf yazsaq da exception cixmayacaq

            Console.WriteLine("Bir eded daxil edin: ");
            int num1 = int.Parse(Console.ReadLine());


            try
            {
                Console.WriteLine("Bir eded daxil edin: ");
                int num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //orginal xeta mesaji
            }
            #endregion




            #region Exception Types

            #region NullReferenceException
            string[] names = null;
            var firstElemnentOfNullArray = names[1].Length; //xeta

            var notReadableCode = 0; //Bu kod hec bir zaman islemeyecek


            try
            {
                var firstElemnent = names[1].Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Array bosdur.");
            }
            catch (Exception ex)
            {
                throw;
            }

            var readableCode = 0;
            #endregion

            #region DivideByZeroException
            try
            {
                Console.WriteLine("Bolmek istediyiniz ededleri daxil edin: ");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());

                decimal divideResult = a / b;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Eded 0-a bolune bilmez!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yuxaridaki catch'lara girmediyi zaman bura girecek.");
            }
            #endregion

            #region KeyNotFoundException
            try
            {
                var keyValuePair = new Dictionary<string, string>();
                keyValuePair.Add("one", "bir");
                keyValuePair.Add("two", "iki");
                keyValuePair.Add("three", "uc");

                var one = keyValuePair["one"];
                var five = keyValuePair["five"];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Axtardiginiz acar movcud deyil");
            }
            #endregion


            #region IndexOutOfRange
            try
            {
                int[] intArray = new int[10];

                for (int i = 0; i < 20; i++)
                {
                    intArray[i] = i;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array'in index araligindan kenar bir index'e deyer menimsetmeye calisdiniz!");
            }
            #endregion


            #region When
            //"nə zaman ki"

            try
            {
                Console.WriteLine("Zehmet olmasa 20-30 araliginda cut reqem daxil edin: ");

                var input = int.Parse(Console.ReadLine());

                if (input % 2 != 0)
                    throw new FormatException("NotDoubleDigit");

                if (!(input >= 20 && input <= 30))
                    throw new FormatException("NotCorrectRange");
            }
            catch (FormatException ex) when (ex.Message == "NotDoubleDigit")
            {
                Console.WriteLine("Daxil etdiyiniz reqem cut reqem deyil!");
                throw;
            }
            catch (FormatException ex) when (ex.Message == "NotCorrectRange")
            {
                Console.WriteLine("Daxil edilen reqem cut reqem olsa da, ancaq 20-30 araliginda deyil!");
                throw;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Xahis olunur reqem daxil edin!");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            #endregion


            #endregion
        }
    }
}

using System;

namespace LoopsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-ci taskin solution'u
            #region Solution 1
            //Console.WriteLine("Toplamaq istediyiniz reqemleri daxil edin: ");
            //Console.WriteLine("Qeyd: Neticeni gormek ucun menfi bir deyer yazin: ");

            //int sum = 0;
            //while (true)
            //{
            //    string uInput = Console.ReadLine();
            //    int value = int.Parse(uInput);

            //    if (value < 0)
            //        break;
            //    else
            //        sum = sum + value;
            //}

            //Console.WriteLine("Toplam: {0}", sum);
            #endregion




            #region Solution 2
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        int result = i * y;
            //        Console.Write("{0}*{1}={2}\t", i, y, result);
            //    }
            //    Console.WriteLine();
            //}
            #endregion




            #region Solution 3
            //int estimate, generatedNum, counter = 0;

            //Console.WriteLine("Texmin oyunu ucun en yuksek deyeri daxil edin: ");
            //int maxNum = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //generatedNum = rand.Next(1, maxNum);

            //do
            //{
            //    counter++;
            //    Console.WriteLine("{0}. Cehdiniz! Zehmet olmasa reqemi texmin edin: ", counter);
            //    estimate = int.Parse(Console.ReadLine());
            //} while (estimate != generatedNum);

            //Console.WriteLine("{0}. Cehdinizde duzgun reqemi tapdiniz!", counter);
            #endregion




            #region Solution 4
            //Console.WriteLine("Bir reqem daxil edin: ");
            //string c = Console.ReadLine();
            //Console.WriteLine("------------------------------------");
            //int cntr = int.Parse(c);

            //while (cntr != -1)
            //{
            //    Console.WriteLine(cntr);
            //    cntr--;
            //}
            #endregion

            Console.ReadLine();
        }
    }
}

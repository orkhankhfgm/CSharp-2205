using System;

namespace ArraysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Solution 1
            //Console.WriteLine("Arrayin uzunlugunu yazin: ");
            //int arrLength = int.Parse(Console.ReadLine());

            //int[] arr = new int[arrLength];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("{0}. index: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Array dolduruldu!");

            //Console.WriteLine("Arrayin elementlerinin toplami ve ortalama deyeri barede melumat: ");
            //Console.WriteLine("--------------------------------------------------------------------------");

            //int total = 0, average = 0;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //    total += item;
            //}

            //Console.WriteLine("--------------------------");

            //Console.WriteLine(total);

            //Console.WriteLine("Arrayin icindeki toplam element sayi: {0}", arr.Length);

            //average = total / arr.Length;

            //Console.WriteLine("Ortalama: {0}", average);
            //Console.WriteLine("-------------------------");
            #endregion



            #region Solution 2
            //int[] numArr = { 20, 92, 100, 55, 124, 1, 500, 945, 75, 25, 3, 5, 999 };
            //int temp, j;

            //for (int i = 1; i < numArr.Length; i++)
            //{
            //    if(numArr[i] < numArr[i - 1])
            //    {
            //        temp = numArr[i];

            //        for (j = i; j > 0 && temp < numArr[j - 1]; j--)
            //            numArr[j] = numArr[j - 1];

            //        numArr[j] = temp;
            //    }
            //}

            //foreach (var item in numArr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



            #region Solution 3
            int[] randNums = new int[100];
            Random rand = new Random();

            int min = 100000;
            int max = 0;
            int sum = 0;

            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rand.Next(1, 100000);

                if (randNums[i] > max)
                    max = randNums[i];

                if (randNums[i] < min)
                    min = randNums[i];

                sum += randNums[i];
            }

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Sum: " + sum);
            #endregion


            Console.ReadLine();
        }
    }
}

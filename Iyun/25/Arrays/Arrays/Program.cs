using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region How to create instance of an array
            ////Numune 1
            //int[] numArray = new int[6];
            //numArray[0] = 100;

            //int getValue = numArray[0];
            //Console.WriteLine(numArray[0]);


            ////Numune 2
            //int[] secondNumArray; //(stack'da yarandi)
            //secondNumArray = new int[6]; //(heap'da yaranib ref adresi stack'a kocuruldu)

            ////Numune 3
            //int[] thirdNumArray = new int[6]
            //{
            //    1,
            //    2,
            //    3,
            //    4,
            //    5,
            //    6
            //};

            ////thirdNumArray[7] = 5; //IndexOutOfRangeException xetasi bas verecek


            ////Numune 4
            //int[] fourthNumArray = new int[]
            //{
            //    10,
            //    20,
            //    30,
            //    40,
            //    50
            //};
            #endregion


            #region Use arrays with diffrent data types
            ////string
            //string[] names = new string[5];
            //names[0] = "Orkhan";
            //names[1] = "John";
            //names[2] = "Mark";
            //names[3] = "Jeff";
            //names[4] = "Bill";


            //var orkhan = names[0];
            //var john = names[1];
            //var mark = names[2];
            //var jeff = names[3];
            //var bill = names[4];
            ////var indexOutOfRange = names[5];

            ////char
            //char[] alphabet = new[]
            //{
            //    'A',
            //    'B',
            //    'C',
            //    'D'
            //};

            ////object
            //object[] objArr = new object[7];
            //objArr[0] = 5;
            //objArr[1] = "string type value";
            //objArr[2] = true;
            //objArr[3] = 2.5F;
            //objArr[4] = DateTime.Now;
            //objArr[5] = 999999999999999999;

            //DateTime date = new DateTime(1995, 12, 12);
            //objArr[6] = date;

            //int intType = (int)objArr[0];
            //string stringType = (string)objArr[1];
            //bool boolType = (bool)objArr[2];
            //float floatType = (float)objArr[3];
            //DateTime dateTimeType = (DateTime)objArr[4];
            //long longType = (long)objArr[5];
            //DateTime dateTimeType2 = (DateTime)objArr[6];
            #endregion


            #region Loop Arrays
            //Console.WriteLine("Sinifde nece telebe olacaq?");
            //short studentCount = Convert.ToInt16(Console.ReadLine());

            //string[] students = new string[studentCount];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(i + ". Telebenin adini daxil edin: ");
            //    string studentName = Console.ReadLine();
            //    students[i] = studentName;
            //}

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(i + ". " + students[i]);
            //}

            #region Task in Lesson 2
            /*
             Task description:
             İki dənə array yaradacaqsız və user'dən tələbənin ad və yaş məlumatlarını alıb bu array'lərdə saxlayacaqsız. Array'ların ölçüsü eyni
             olacaq və onu da user'dən soruşacaqsız. Sonra döngüdə istifadəçidən ad və yaş məlumatlarını ayrı-ayrılıqda soruşub array'lərə
             dolduracaqsız. Sonra başqa bir for döngüsündə tələbənin ad və yaş məlumatlarını index'lə birlikdə ekrana yazdıracaqsız.
             (0. Orkah 27 yaşındadır.)
             */
            //Console.WriteLine("Sinifde neçe telebe olacaq?");
            //int stCount = Convert.ToInt32(Console.ReadLine());
            //string[] stNames = new string[stCount];
            //byte[] stAges = new byte[stCount];

            //for (int i = 0; i < stCount; i++) 
            //{
            //    Console.WriteLine(i + ". Telebenin adini daxil edin:");
            //    string stName = Console.ReadLine();

            //    Console.WriteLine(i + ". Telebenin yasini daxil edin:");
            //    byte stAge = Convert.ToByte(Console.ReadLine());

            //    stNames[i] = stName;
            //    stAges[i] = stAge;
            //}

            //for (int i = 0; i < stCount; i++)
            //{
            //    Console.WriteLine((i+1) + ". " + stNames[i] + " " + stAges[i] + " yasindadir.");
            //}

            ////Eyni qaydada bir array'ı foreach döngüsünə də salmaq olur. Foreach döngüsündə artıq index'lə müraciət etməyə ehtiyyac yoxdur.
            //int count = 0;
            //foreach (string item in stNames)
            //{
            //    Console.WriteLine((count+1) + ". " + item + " " + stAges[count] + " yasindadir.");
            //    count++;
            //}
            #endregion
            #endregion


            #region Multidimensional Arrays
            ////5x2 (Matris Arrays)
            //int[,] _5x2 = {
            //    { 1, 2},
            //    { 3, 4},
            //    { 5, 6},
            //    { 7, 8},
            //    { 9, 10}
            //};

            ////int[] test = new int[]
            ////{
            ////    1,
            ////    2,
            ////    3
            ////};

            ////(Jagged Array)
            //int[][] jaggedArr = new int[][]
            //{
            //    new int[2]{ 100, 200},//Array
            //    new int[6]{ 101, 102, 103, 104, 105, 106},//Array
            //    new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},//Array
            //    new int[]{ 1000, 2000, 3000, 4000, 5000},//Array
            //};

            //jaggedArr[0][0] = 500;
            //jaggedArr[2][3] = 150;

            //for (int i = 0; i < jaggedArr.Length; i++)
            //{
            //    for (int x = 0; x < jaggedArr[i].Length; x++)
            //    {
            //        Console.WriteLine(i + "." + x + ": " + jaggedArr[i][x]);
            //    }
            //}
            #endregion


            #region Array Methods
            /*
             Properties:
                IsFixedSize - Element saylarinin sabit olub olmamasini bildirir. (bool)
                IsReadOnly - Element deyerlerinin deyisdirile bilmesi barede melumat verir. (bool)
                Length - Array'in olcusu (nece dene elementi oldugu) barede melumat verir. (int)

             Methods:
                Clone() - Array'i oldugu kimi klonlayir.
                Array.IndexOf() - bir array'daki elementin index'ini verir.
                CopyTo() - Array'i basqa bir array'a kopyalayir.
                Sort() - Artan sira ile siralayir.
                Reverse() - Tersine siralayir.
                Clear() - Array'in elementlerinin deyerlerini default deyere resetleyir.
             */

            string[] persons = new string[]
            {
                "Orxan Ferecov",
                "Bill Gates",
                "Steve Jobs",
                "Mark Zuckenberg"
            };

            bool isFixedSize = persons.IsFixedSize;
            bool isReadOnly = persons.IsReadOnly;
            int length = persons.Length;

            var clonedArray = persons.Clone();
            int orkhansIndex = Array.IndexOf(persons, "Orxan Ferecov");

            string[] copiedPersons = new string[10];
            persons.CopyTo(copiedPersons, 4);

            Array.Sort(persons);

            Array.Reverse(persons);

            Array.Clear(persons, 2, 2);
            #endregion
            Console.ReadLine();
        }
    }
}

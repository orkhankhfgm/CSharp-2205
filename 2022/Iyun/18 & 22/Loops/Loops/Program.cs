using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For
            //Foreach
            //While
            //Do-While

            #region For Loop
            {
                //Nümunə 1:
                //for (int i = 0; i < 100; i++)
                //{
                //    Console.WriteLine("Salam");
                //}

                ////Nümunə 2: 0-9
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine(i);
                //}

                ////Nümunə 3: 1-10
                //for (int i = 0; i <= 10; i++)
                //{
                //    Console.WriteLine(i);
                //}

                ////Nümunə 4: 0-8
                //for (int i = 0; i < 100; i+=2)
                //{
                //    Console.WriteLine(i);
                //}

                ////Nümunə 5:
                //for (int i = 0; i < 100; i+=10)
                //{
                //    Console.WriteLine(i);
                //}

                //Nümunə 6:
                //infinity loop
                //for (; ;)
                //{
                //    Console.WriteLine("Hi");
                //}

                //Nümunə 7:
                //int counter = 0;
                //for (; ;counter++)
                //{
                //    Console.WriteLine("Counter: " + counter);
                //}

                //Nümunə 8:
                //for (int i = 0; i < 5; i++)
                //    Console.WriteLine("Oneline for: " + i);

                //Nümunə 9: break keyword'u
                //for (int i = 0; i < 10; i++)
                //{
                //    if (i == 5)
                //        break;

                //    Console.WriteLine("Counter: " + i);
                //}



                ////Nested loop
                //for (int i = 0; i < 10; i++)
                //{
                //    for (int x = 0; x < 10; x++)
                //    {
                //        Console.WriteLine("i: " + i + " --- x: " + x);
                //    }
                //}

                ////Nümunə 10: nested loop 2
                //for (int a1 = 0; a1 < 10; a1++)
                //{
                //    for (int b1 = 0; b1 < 10; b1++)
                //    {
                //        for (int c1 = 0; c1 < 10; c1++)
                //        {
                //            for (int d1 = 0; d1 < 10; d1++)
                //            {
                //                Console.WriteLine("a:" + a1 + " --- b:" + b1 + " --- c:" + c1 + " --- d:" + d1);
                //            }
                //        }
                //    }
                //}

                //Nümunə 11: Yolka ağacı
                //for (int i = 1; i <= 20; i++)
                //{
                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                /*
                 Task 1: 1-dən 100-ə qədər olan rəqəmlərin toplamını ekrana yazdırın.
                 Task 2: Sadəcə cüt rəqəmlərin toplamını ekrana yazdırın.
                 */
                //Solution 1
                //int result = 0;
                //for (int i = 0; i <= 100; i++)
                //    result += i;

                //Console.WriteLine("1-den 100-e qeder olan reqemlerin toplami: " + result);

                ////Solution 2
                //result = 0;
                //for (int i = 0; i <= 100; i++)
                //{
                //    if ((i % 2) == 0)
                //        result += i;
                //}
                //Console.WriteLine("1-den 100-e qeder olan cut reqemlerin toplami: " + result);
                //Console.ReadLine();
            }
            #endregion


            #region While (O vaxta qeder ki)
            {
                ////Numune 1
                //var continueLoop = true;

                //while (continueLoop)
                //{
                //    int sec = DateTime.Now.Second;

                //    if (sec >= 30 && sec <= 45)
                //    {
                //        Console.WriteLine("End");
                //        break;
                //    }
                //    else
                //    {
                //        Console.WriteLine(sec);
                //    }
                //}

                ////Numune 2
                //int countWhile = 1;
                //while (countWhile <= 100)
                //{
                //    Console.WriteLine("Counter: " + countWhile);
                //    countWhile++;
                //}

                #region Task in Lesson
                ////Userden davamli input almaq lazimdir. Exit sozunu yazdigi zaman dongunu dayandirmaq lazimdir.
                ////1-ci variant
                //while (true)
                //{
                //    string text = Console.ReadLine();
                //    if(text != "exit")
                //    {
                //        Console.WriteLine(text);
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}


                ////2-ci variant
                //var stopLoop = false;
                //while (!stopLoop)
                //{
                //    string text = Console.ReadLine();
                //    if(text != "exit")
                //    {
                //        Console.WriteLine(text);
                //    }
                //    else
                //    {
                //        stopLoop = true;
                //    }
                //}
                #endregion
            }
            #endregion


            #region Do While Loop
            //bool startChat = false;

            //while (startChat)
            //{
            //    if (startChat == false)
            //    {
            //        Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        string answer = Console.ReadLine();

            //        if (answer == "He")
            //            startChat = true;
            //        else if (answer == "Yox")
            //            break;
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Sehv cavab daxil etdiniz!");
            //            Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mesajinizi daxil edin: ");
            //        string text = Console.ReadLine();

            //        if (text == "exit")
            //            break;

            //        Console.WriteLine(text);
            //    }
            //}



            //do
            //{
            //    if (startChat == false)
            //    {
            //        Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        string answer = Console.ReadLine();

            //        if (answer == "He")
            //            startChat = true;
            //        else if (answer == "Yox")
            //            break;
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Sehv cavab daxil etdiniz!");
            //            Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mesajinizi daxil edin: ");
            //        string text = Console.ReadLine();

            //        if (text == "exit")
            //            break;

            //        Console.WriteLine(text);
            //    }
            //} while (startChat);
            #endregion




            #region Foreach
            //string[] citiesArray = new string[10];
            //citiesArray[0] = "Baki";
            //citiesArray[1] = "Gence";
            //citiesArray[2] = "Sumqayit";
            //citiesArray[3] = "Seki";
            //citiesArray[4] = "Kurdemir";
            //citiesArray[5] = "Naxcivan";
            //citiesArray[6] = "Quba";
            //citiesArray[7] = "Xacmaz";
            //citiesArray[8] = "Lenkeran";
            //citiesArray[9] = "Masalli";

            //foreach (var city in citiesArray)
            //{
            //    Console.WriteLine(city);
            //}
            #endregion


            #region Variable declarations inside/outside loop bodies
            //string globalVariableName = "Orkhan";

            //for (int i = 0; i < 5; i++)
            //{
            //    globalVariableName = "Name can changed here";
            //}

            //string surname = "";

            //for (int i = 0; i < 5; i++)
            //{
            //    string localVariableSurname = "Farajov";
            //    surname = localVariableSurname;
            //    break;
            //    localVariableSurname = "Esedov";
            //    surname = localVariableSurname;
            //}

            //var test = surname;

            //localVariableSurname = "Surname can't be changed here because it is local variable inside for loop";
            int a = 5;
            Random rand = new Random();
            int b = rand.Next(1, 100);
            #endregion
        }
    }
}

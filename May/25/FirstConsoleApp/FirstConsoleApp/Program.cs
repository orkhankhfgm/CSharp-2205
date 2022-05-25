using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Visual Studio
            /*
             - Visual Studio is a IDE.
             - To create new project ->: CTRL + Shift + N

             */
            #endregion




            #region First C# Code
            //Console.Write("Hello ");
            //Console.Write("World");

            //Console.WriteLine("Hello World");
            //Console.Write("Orkhan");
            #endregion




            //(System - Namespace adi)
            //(Console - System namespace'nin icinde bir class adi)
            //(Write - Console class'inin icindeki bir funksiyanin/method'un adi)





            #region Read user input
            //Console.WriteLine("Salam, xos gelmisiniz!");
            //Console.WriteLine("Adinizi daxila edin:");

            //var read = Console.Read(); //Read method'u basilan ilk simvolun key kodunu gosterir. Mes: H - 72
            //var readLine = Console.ReadLine(); //ReadLine method'u butun setiri metn olaraq qaytarir.
            //var readKey = Console.ReadKey(); //ReadKey method'u basilan ilk simvolun keychar'ini ve kodunu alir. Key=H, keyChar = 72

            //var welcomeMsg = "Xos gelmisiniz!";
            //Console.WriteLine(welcomeMsg);

            //var whatIsYourName = "Adiniz nedir?";
            //Console.WriteLine(whatIsYourName);

            //Console.ReadLine();
            #endregion




            #region Breakpoint
            //Console.WriteLine("Top 1");
            //Console.WriteLine("Top 2");
            //Console.WriteLine("Top 3");
            //Console.WriteLine("Top 4");
            //Console.WriteLine("Top 5");
            //Console.WriteLine("Top 6");
            //Console.WriteLine("Top 7");
            //Console.WriteLine("Top 8");
            //Console.WriteLine("Top 9");
            //Console.WriteLine("Top 10");
            //Console.ReadLine();

            /*
             Breakpoint atdiqdan sonra yeni debug etdiyimiz zaman:
                - F10'a basanda oldugunuz setirden sonraki ilk kod olan setre aparir.
                - F5-e basanda oldugunuz setirden sonraki butun kodlari oxuyub icra edir.
                - Kodu bir ve ya bir nece statement geriye aparmaq ucun soldaki sari ox isaresini yuxari cekmek lazimdir.
                Bu hemin kodlari tekrar icra etmesini temin edir.
             */
            #endregion




            #region Task in Lesson 2
            /*
             1. red - qirmizi
             2. car - avtomobil
             3. expensive - bahali
             4. phone - telefon

             qirmizi avtomobil
             bahali telefon
             */
            #endregion




            #region Comment and Region
            /*
             Iki nov comment var, biri single-line digeri multiple-line
             */

            //Registration section
            //var red = "qirmizi ";

            /*
             Salam
             necesen
             yaxsiyam.
             var red = "qirmizi ";
             */
            #endregion




            #region Registration

            #endregion

            #region Login

            #endregion

            #region Edit Profile info

            #endregion




            #region Variables
            //(typeOfVariable nameOfVariable = valueOfVariable)
            //var red1 = "Qirmizi reng";
            //Console.WriteLine(red1);
            //Console.ReadLine();

            string person = "Orkhan Farajov";
            Console.WriteLine(person);


            string anotherPerson;
            

            string name = "Orkhan";
            Console.WriteLine(name);

            name = "Hesen Babayev";
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);
            Console.WriteLine(name);


            anotherPerson = "Ceyhun Babayev";
            Console.ReadLine();
            #endregion





            #region Naming Convention
            //My Comment
            var nameSurname = "176 No. mekteb";
            
            /*
             Wrong naming convention         -          Right naming convention:
             _namesurname                               _nameSurname
             namesurname                                nameSurname
             emailaddress                               emailAddress
             redcarname                                 redCarName
             redCarNamE                                 redCarName

             Wrong syntax:
              *nameSurname
              )myVariable
              name-surname
             */
            #endregion
        }
    }
}
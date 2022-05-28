using System;

namespace First_Console_App_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String helper methods
            string name = "Orkhan";
            string fullname = "Orkhan Farajov";

            int age = 27; //integer
            string book = "Rhonda Byrne - The Secret";
            string usd = "$";

            string five = "5";
            string one = "1";

            int five_ = 5;
            int one_ = 1;

            string upperCaseFullname = fullname.ToUpper();

            Console.WriteLine(upperCaseFullname);
            Console.WriteLine(fullname.ToLower());

            Console.WriteLine(five + one);
            Console.WriteLine(five_ + one_);

            Console.WriteLine(name + " is " + age + " years old.");
            //Orkhan is 27 years old.

            //ATTENTION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.Clear();
            string partOfString = fullname.Substring(5, 2);
            string partOfString2 = fullname.Substring(5);
            //"Orkhan Farajov"
            // 0123456789
            #endregion

            /*
             RAM = Random Access Memory
             1. S-RAM (Static RAM)
             2. D-RAM (Dynamic RAM)
             3. SD-RAM / SDR-SD RAM (Synchronous Dynamic RAM)
             4. DDR SD RAM (Double Data Rate Synchronous Dynamic RAM)
             5. GDDR SD RAM (Graphics Double Data Rate Synchronous Dynamic RAM)



             //Dəyişən növləri:
             1.Value-Type
             2.Reference-Type
             3.Pointer-Type
             */

            #region Value Type Variables
            //Nümunə 1
            int a; //4 byte
            a = 5;

            //Nümunə 2
            int b;
            b = 5;
            b = 17;

            //Nümunə 3
            int c = 5200;
            c = 2147483647;

            //Nümunə 4
            int i = 2147483647; //(int RAM'da 4 byte yer tutur)
            double x = 500; //(double RAM'da 8 byte yer tutur)
            x = i;
            //i = x; //(wrong)
            x = 150;
            #endregion




            #region Referance Type Variables
            Student student = new Student();
            student.Name = "Ceyhun";
            student.Age = 27;
            student.Point = 78.5;
            #endregion



            #region Reason of NullReferanceException
            var studentClassNumber = student.ClassRoom.Number;
            #endregion



            #region Assign one Referance Type to another
            Student otherStudent = new Student();
            otherStudent.Name = "Babək";
            otherStudent.Age = 29;
            otherStudent.Point = 71.6;

            student = otherStudent;
            student.Name = "test";
            #endregion
        }
    }
}

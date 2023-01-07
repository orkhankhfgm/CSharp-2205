using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalLesson
{
    public class Helper
    {
        public static void ShowStudentInfo(int studentId, string studentName, string studentSurname, string studentEmail, int studentGender)
        {
            Console.WriteLine(studentId);
            Console.WriteLine(studentName);
            Console.WriteLine(studentSurname);
            Console.WriteLine(studentEmail);
            Console.WriteLine(studentGender);
        }

        public static void ShowStudentInfo(Student student)
        {
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.Gender);
        }

        public static int TestMethod()
        {
            return 1;
        }

        public static string TestMethod1()
        {
            return "salam";
        }

        public static double TestMethod2()
        {
            return 5.5d;
        }

        public static Student GetStudentFromDatabase()
        {
            /*
             Bu hissede database'e baglanib, melumatlar cekilib elde edilir.
             */
            Student student = new Student();
            student.Id = 155;
            student.Name = "Cavid";
            student.Surname = "Penahov";
            student.Email = "cavid@gmail.com";
            student.Gender = 1;

            return student;
        }

        public Student GetStudentFromDatabase2()
        {
            /*
             Bu hissede database'e baglanib, melumatlar cekilib elde edilir.
             */
            Student student = new Student();
            student.Id = 175;
            student.Name = "Samir";
            student.Surname = "Hesenov";
            student.Email = "samir@gmail.com";
            student.Gender = 1;

            return student;
        }
    }
}

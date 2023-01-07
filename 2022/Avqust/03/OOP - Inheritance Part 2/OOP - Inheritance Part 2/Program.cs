using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor methods while inheritance
            Teacher teacher = new Teacher();

            Student student = new Student();
            #endregion

            #region Access to base class methods
            Person person = new Person();
            person.GoodPerson();

            Teacher teacher2 = new Teacher();
            teacher2.GoodPerson();
            #endregion

            #region Assignment sub class to parent class
            Student student1 = new Student();
            object obj = student1;

            //Student s1 = obj; //(error verecek)
            Student s1 = (Student)obj; //(casting ile)

            Person p1;
            p1 = s1;
            p1 = new Teacher();

            //eksi
            //s1 = new Person(); //(error verecek)
            s1 = (Student)p1;
            /*ve ya*/
            s1 = (Student)new Person();

            object objPerson = new Person();
            object objStudent = new Student();
            object objTeacher = new Teacher();
            #endregion
        }
    }
}

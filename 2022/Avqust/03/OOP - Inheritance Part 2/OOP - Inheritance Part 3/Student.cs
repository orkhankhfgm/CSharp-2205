using System;

namespace OOP___Inheritance_Part_3
{
    public sealed class Student : Person
    {
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attendance { get; set; } //(davamiyyet 100/0)

        public Student()
        {
            Console.WriteLine("CTOR: Student class");
            MyProtectedMethod();
        }
    }
}

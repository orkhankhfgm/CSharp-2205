using System;

namespace OOP___Inheritance_Part_3
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Person()
        {
            Console.WriteLine("Constructor of Person class");
        }

        protected void MyProtectedMethod()
        {
            Console.WriteLine("This method is protected");
        }

        public void Test()
        {
            Console.WriteLine("Test called MyProtectedMethod...");
            MyProtectedMethod();
        }
    }
}

using System;

namespace Methods_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is method?
            Console.WriteLine("jhfdbjhfd");
            SayHello();
            #endregion



            #region Practise with methods
            Student studentInstance = new Student();
            studentInstance.HelloStudent();
            studentInstance.ShowHasanInfo();

            //studentInstance.ShowStudentInfo(); //(bu methodu private oldugu ucun burada istifade ede bilmirem)
            #endregion
        }

        static void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
}

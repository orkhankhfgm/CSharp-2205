using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Delegate

            #region Calc without delegate
            void Addition(int a, int b)
            {
                Console.WriteLine("Toplama neticesi: " + (a + b));
            }

            void Subtraction(int a, int b)
            {
                Console.WriteLine("Cixmanin neticesi: " + (a - b));
            }

            void Multiplication(int a, int b)
            {
                Console.WriteLine("Vurmanin neticesi: " + a * b);
            }

            void Division(int a, int b)
            {
                Console.WriteLine("Bolmenin neticesi: " + a / b);
            }

            //Addition(10, 20);
            //Subtraction(50, 35);
            //Multiplication(2, 40);
            //Division(100, 4);
            #endregion

            Calc delegateCalc = new Calc(Addition);
            delegateCalc += Subtraction;
            delegateCalc += Multiplication;
            delegateCalc += Division;

            delegateCalc(10, 20);

            int OtherMethod(bool a)
            {
                return 0;
            }
            //delegateCalc += OtherMethod; //error

            Delegate[] delegates = delegateCalc.GetInvocationList();

            foreach (var item in delegates)
            {
                Console.WriteLine($"Method name: {item.Method.Name}");
                Console.WriteLine($"Return type: {item.Method.ReturnType.Name}");
                Console.WriteLine($"Is static: {item.Method.IsStatic}");
                Console.WriteLine($"Is public: {item.Method.IsPublic}");
                Console.WriteLine($"Is ctor: {item.Method.IsConstructor}");
                Console.WriteLine($"Is abstract: {item.Method.IsAbstract}");
            }

            delegateCalc -= Subtraction;

            foreach (var item in delegateCalc.GetInvocationList())
            {
                Console.WriteLine($"Method name: {item.Method.Name}");
            }

            Console.Clear();

            //Lambda expression ilə
            ShowPersonInfo delegateWithLambda = (Person p) => Console.WriteLine($"Name: {p.Name} Surname: {p.Surname}");
            Person person = new Person("Orkhan", "Farajov", 27, "orkhankhf@gmail.com");
            delegateWithLambda.Invoke(person);

            delegateWithLambda = (Person p) => Console.WriteLine($"{p.Name} is {p.Age} years old. Contact: {p.Email}");
            delegateWithLambda(person); //1-ci versiya
            delegateWithLambda.Invoke(person); //2-ci versiya

            Console.Clear();
            //Adsız method ilə
            ShowPersonInfo delegateWithUnnamedMethod = new ShowPersonInfo(delegate (Person p)
            {
                Console.WriteLine($"Hello {p.Name} {p.Surname}! You are {p.Age} years old and your email address is {p.Email}");
            });
            delegateWithUnnamedMethod(person);
            #endregion
        }

        delegate void Calc(int a, int b);

        public delegate void ShowPersonInfo(Person person);
    }
}

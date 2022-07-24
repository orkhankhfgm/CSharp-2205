using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class ExampleConstructorClass
    {
        //Static class'ın standart constructor'u ola bilməz!
        //public ExampleConstructorClass()
        //{

        //}


        static ExampleConstructorClass()
        {
            Console.WriteLine("ctor...");
        }

        #region Static ShowPersonInfo method
        public static void ShowPersonInfo()
        {
            Console.WriteLine("Name: Orkhan");
            Console.WriteLine("Surname: Farajov");
            Console.WriteLine("Age: 27");
        }
        #endregion
    }
}

using MathOperations;
using MathOperations.Enums;
using System;

namespace SomeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = MathOperation.Calculate(20, 40, MathOperationTypeEnum.Addition);
            var x = Convert.ToInt32("15");
            var c = MathOperation.MyConstValue;
        }
    }
}

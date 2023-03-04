using MathOperations.Enums;
using System;

namespace MathOperations
{
    public static class MathOperation
    {
        public const int MyConstValue = 200;

        #region Public methods
        public static decimal Calculate(decimal a, decimal b, MathOperationTypeEnum operationType)
        {
            switch (operationType)
            {
                case MathOperationTypeEnum.Addition:
                    return Addition(a, b);
                case MathOperationTypeEnum.Subtraction:
                    return Subtraction(a, b);
                case MathOperationTypeEnum.Multiplication:
                    return Multiplication(a, b);
                case MathOperationTypeEnum.Divide:
                    return Divide(a, b);
                default:
                    throw new Exception("Səhv əməliyyat növü seçilib!");
            }
        }
        #endregion

        #region Private methods
        private static decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        private static decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        private static decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        private static decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
                throw new Exception("Ədadi sıfıra bölə bilməzsiniz!");

            return a / b;
        }
        #endregion
    }
}

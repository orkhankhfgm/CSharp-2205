using System;

namespace Methods___Homework
{
    public class Calculate
    {
        #region For Decimal        public decimal Calc(int opp, decimal num1, decimal num2)        {            decimal total = 0;            decimal Addition(decimal a, decimal b)            {                return a + b;            }            decimal Subtraction(decimal a, decimal b)            {                return a - b;            }            decimal Multiplication(decimal a, decimal b)            {                return a * b;            }            decimal Division(decimal a, decimal b)            {                if (b != 0)                    return a / b;                else                    return 0;            }            decimal Interest(decimal a, decimal b)            {                return (a * b) / 100;            }            decimal InterestRate(decimal a, decimal b)            {                return (a / b) * 100;            }            switch (opp)            {                case 1:                    total = Addition(num1, num2);                    break;                case 2:                    total = Subtraction(num1, num2);                    break;                case 3:                    total = Multiplication(num1, num2);                    break;                case 4:                    total = Division(num1, num2);                    break;                case 5:                    total = Interest(num1, num2);                    break;                case 6:                    total = InterestRate(num1, num2);                    break;            }            return total;        }
        #endregion


        #region For Int
        public decimal Calc(int opp, int num1, int num2)
        {
            decimal _num1 = Convert.ToDecimal(num1);
            decimal _num2 = Convert.ToDecimal(num2);

            return Calc(opp, _num1, _num2);
        }
        #endregion

        #region For Int
        public decimal Calc(int opp, string num1, string num2)
        {
            decimal _num1 = Convert.ToDecimal(num1);
            decimal _num2 = Convert.ToDecimal(num2);

            return Calc(opp, _num1, _num2);
        }
        #endregion

        #region For Int
        public decimal Calc(int opp, string num1, decimal num2)
        {
            decimal _num1 = Convert.ToDecimal(num1);
            decimal _num2 = Convert.ToDecimal(num2);

            return Calc(opp, _num1, _num2);
        }
        #endregion

        #region For Int
        public decimal Calc(int opp, string num1, int num2)
        {
            decimal _num1 = Convert.ToDecimal(num1);
            decimal _num2 = Convert.ToDecimal(num2);

            return Calc(opp, _num1, _num2);
        }
        #endregion

        #region For Int
        public decimal Calc(int opp, decimal num1, int num2)
        {
            decimal _num1 = Convert.ToDecimal(num1);
            decimal _num2 = Convert.ToDecimal(num2);

            return Calc(opp, _num1, _num2);
        }
        #endregion
    }
}

﻿using System;

namespace Methods___Homework
{
    public class Calculate
    {
        #region For Decimal
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
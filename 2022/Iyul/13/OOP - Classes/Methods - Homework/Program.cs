namespace Methods___Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            var decValue = calc.Calc(1, 15.5M, 20.5M);
            var intValue = calc.Calc(1, 5, 10);
            var stringValue = calc.Calc(1, "5", "20");
            var stringDecValue = calc.Calc(1, "5", 20.5M);
            var stringIntValue = calc.Calc(1, "5", 20);
            var decIntValue = calc.Calc(1, 20.5M, 15);
        }
    }
}

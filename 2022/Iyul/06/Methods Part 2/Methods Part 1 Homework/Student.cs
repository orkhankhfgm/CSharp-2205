using System;

namespace Methods_Part_1_Homework
{
    public class Student
    {
        public void CalcAverage(string name, string surname, decimal p1, decimal p2, decimal p3)
        {
            Console.WriteLine("Telebe melumatlari: ");
            Console.WriteLine("Ad Soyad : {0} {1}", name, surname);

            //(birinci yazi qaydasi)
            decimal average = CalcAverage(p1, p2, p3);
            RateAverage(average);

            //(ikinci yazi qaydasi)
            RateAverage(CalcAverage(p1, p2, p3));
        }

        void RateAverage(decimal avrg)
        {
            if(avrg < 45)
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kesildiniz!", avrg);
            else
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kecdiniz!", avrg);
        }

        private decimal CalcAverage(decimal p1, decimal p2, decimal p3)
        {
            //(birinci yazi qaydasi)
            decimal avrg = (p1 + p2 + p3) / 3;
            return avrg;

            //(ikinci yazi qaydasi)
            return (p1 + p2 + p3) / 3;
        }
    }
}

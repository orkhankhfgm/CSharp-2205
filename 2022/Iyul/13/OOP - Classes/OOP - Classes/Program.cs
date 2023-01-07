using System;

namespace OOP___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             -Müştəri
             -Satış təmsilçisi
             -Satılacaq məhsul (Avtomobil, motosiklet və s.)


             Satışın həyata keçirilməsi üçün lazım olanlar:
             -Müştəri
             -Satış təmsilcisi
             -Satılacaq məhsul
             -Təklif
             -Sifariş
             -Qəbz

             -Müştəri
                -Ad
                -Soyad
                -Cinsiyyət
                -Passportunun seriyası və nömrəsi
                -Ünvanı

             -Məhsul
                -Marka
                -Model
                -İl
                -Km
                -Yanacaq növü
                -Ban növü

             -Təklif
                -Təklif nömrəsi
                -Müştəri
                -Satıcı
                -Məhsul
                -Qiymət

             -Sifariş
                -Sifariş nömrəsi
                -Təklif
                -Qiymət

             -Qəbz
                -Vergi nömrəsi
                -Qəbz nömrəsi
                -Seriya
                -Təklif
                -Müştəri
             */

            Console.WriteLine("I am software developer!");

            string name = "Orkhan";
            
            Customer orkhan = new Customer();
            orkhan.Name = "Orkhan";
            //orkhan.Surname = "Farajov"; //(private olduğu üçün əlçatan deyil) (sonradan dəyişib public etdim deyə əlçatan olacaq)
            orkhan.Surname = "Farajov";
            orkhan.Gender = 1;
            orkhan.DocumentSerial = "AZ";
            orkhan.DocumentNumber = "123456";
            orkhan.Address = "Bakı şəh., Nərimanov r-nu., Rasim Muxtarov küç., No 5";



            Customer otherCustomer = new Customer();

            otherCustomer = orkhan;

            otherCustomer.Name = "Name changed for otherCustomer";
            orkhan.Surname = "Surname changed for orkhan";

            //otherCustomer = null;
            //orkhan = null;

            string customerName = orkhan.Name;
            string otherCustomerName = otherCustomer.Name;

            Customer customer2 = new Customer();
            Customer overload1 = new Customer("123456");
            Customer overload2 = new Customer("123456", "AA");
            Customer overload3 = new Customer("123456", "AA", "Orkhan", "Farajov");
            Customer overload4 = new Customer(1, "Orkhan", "Farajov");
            Customer overload5 = new Customer("123456", "AA", 1, "Orkhan", "Farajov", "Baki seh.");

            string ov5Name = overload5.Name;

            //var test = overload5.CheckCustomerFromDb(); //(private olduğu üçün başqa class'dan əlçatan deyil.)

            var checkResult = overload5.CheckCustomer(); //(public olduğu üçün əlçatandır.)

            if (checkResult)
            {
                Console.WriteLine("İstifadəçi qeydiyyatdan keçə bilər.");
            }
            else
            {
                Console.WriteLine("Bu istifadəçi daha əvvəl qeydiyyatdan keçib!");
            }

        }
    }
}

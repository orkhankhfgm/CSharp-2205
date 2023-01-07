using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatements_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
             */
            //const string username = "admin";
            //const string password = "admin";

            //Console.WriteLine("Istifadeci adinizi yazin: ");
            //string u = Console.ReadLine();

            //Console.WriteLine("Parolunuzu yazin: ");
            //string p = Console.ReadLine();

            ////1-ci cehd
            //if(u == username && p == password)
            //{
            //    Console.WriteLine("Sisteme daxil olundu");
            //}
            //else
            //{
            //    Console.WriteLine("Istifadeci adinizi yazin: ");
            //    u = Console.ReadLine();

            //    Console.WriteLine("Parolunuzu yazin: ");
            //    p = Console.ReadLine();

            //    //2-ci cehd
            //    if(u == username && p == password)
            //    {
            //        Console.WriteLine("Sisteme daxil olundu");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Istifadeci adinizi yazin: ");
            //        u = Console.ReadLine();

            //        Console.WriteLine("Parolunuzu yazin: ");
            //        p = Console.ReadLine();

            //        //3-cu cehd
            //        if(u == username && p == password)
            //        {
            //            Console.WriteLine("Sisteme daxil olundu");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hesab bloklandi!");
            //        }
            //    }
            //}






            ////1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
            //int month = 5;
            //const int feb = 2;

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case feb:
            //        Console.WriteLine("Fevral");
            //        break;
            //    case 3:
            //        Console.WriteLine("MArt");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprel");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("Iyun");
            //        break;
            //    case 7:
            //        Console.WriteLine("Iyul");
            //        break;
            //    case 8:
            //        Console.WriteLine("Avqust");
            //        break;
            //    case 9:
            //        Console.WriteLine("Sentyabr");
            //        break;
            //    case 10:
            //        Console.WriteLine("Oktyabr");
            //        break;
            //    case 11:
            //        Console.WriteLine("Noyabr");
            //        break;
            //    case 12:
            //        Console.WriteLine("Dekabr");
            //        break;
            //}



            //string job = "Mobile Developer";

            //switch (job)
            //{
            //    case "Developer":
            //        Console.WriteLine("Proqramci proqram teminati hazirlayir");
            //        break;
            //    case "Design":
            //        Console.WriteLine("Dizayner muxtelif dizaynlar hazirlayir");
            //        break;
            //    case "Web Designer":
            //        Console.WriteLine("Salam web dizayner");
            //        goto case "Design";
            //    case "Mobile Developer":
            //        Console.WriteLine("Salam mobile developer");
            //        goto case "Developer";
            //}



            ////Multiple cases
            //Console.WriteLine("Rutbe kodunu daxil edin: ");
            //string code = Console.ReadLine();

            //switch (code)
            //{
            //    case "AA":
            //    case "BB":
            //    case "CC":
            //        Console.WriteLine("Admin");
            //        break;
            //    case "DD":
            //    case "FF":
            //        Console.WriteLine("Editor");
            //        break;
            //    case "GG":
            //    case "HH":
            //        Console.WriteLine("Registered User");
            //        break;
            //    case "II":
            //    case "JJ":
            //        Console.WriteLine("Standart User");
            //        break;
            //}




            /*
             Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
             və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
             istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
             */


            string m = "mainMenu";
            decimal a = 0, b = 0;

            switch (m)
            {
                case "mainMenu":
                    Console.WriteLine("A deyeri daxil edin: ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("B deyeri daxil edin: ");
                    b = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Etmek istediyiniz emeliyyati secin: ");
                    Console.WriteLine("1. Toplama");
                    Console.WriteLine("2. Çıxma");
                    Console.WriteLine("3. Vurma");
                    Console.WriteLine("4. Bölme");
                    short choise = Convert.ToInt16(Console.ReadLine());
                    if (choise == 1)
                        goto case "toplama";
                    else if (choise == 2)
                        goto case "cixma";
                    else if (choise == 3)
                        goto case "vurma";
                    else if (choise == 4)
                        goto case "bolme";
                    else
                        Console.WriteLine("Yanlis emeliyyat secdiniz!");
                        goto case "mainMenu";

                case "toplama":
                    Console.WriteLine("Netice: " + a + b);
                    goto case "mainMenu";
                case "cixma":
                    Console.WriteLine("Netice: " + (a - b));
                    goto case "mainMenu";
                case "vurma":
                    Console.WriteLine("Netice: " + a * b);
                    goto case "mainMenu";
                case "bolme":
                    Console.WriteLine("Netice: " + a * b);
                    goto case "mainMenu";

            }
        }
    }
}

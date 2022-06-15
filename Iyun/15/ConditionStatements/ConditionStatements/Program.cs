using System;
using System.Text;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //If-Else
            {
                /*
                 if(sert){
                    //if serti odense bu skoplar arasindaki kodlar islesin
                 }else{
                    //if serti odenmese bu skoplar arasindaki kodlar islesin
                 }
                 */

                ////(sadece if ile)
                //int age = Convert.ToInt32(Console.ReadLine());

                //if (age <= 18)
                //{
                //    Console.WriteLine("Yeniyetme");
                //}

                //if (age > 18)
                //{
                //    Console.WriteLine("Yetiskin");
                //}

                ////(if-else ile)
                //if (age <= 18)
                //{
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //    Console.WriteLine("Yeniyetme");
                //}
                //else
                //{
                //    Console.WriteLine("Yetiskin");
                //}


                ////(skopsuz if else yazmaq)
                //if (age <= 18)
                //    Console.WriteLine("Yeniyetme");
                //else
                //    Console.WriteLine("Yetiskin");


                //Console.WriteLine("Adinizi daxil edin: ");
                //string name = Console.ReadLine(); //orkhan

                //if (name == "orkhan")
                //    Console.WriteLine("name'in deyeri orxan'dir.");
                //else
                //    Console.WriteLine("name'in deyeri orxan deyil.");

                //Console.Clear();

                //bool result = name == "orkhan";
                //if (result)
                //{ //esas boolean tipinde bir deyer qayitmalidir if'in icinde
                //    Console.WriteLine("Salam");
                //    Console.WriteLine("name deyeri orxandir");
                //    Console.WriteLine("sagol");
                //}
                //else
                //{
                //    Console.WriteLine("Salam");
                //    Console.WriteLine("name deyeri orxan deyil");
                //    Console.WriteLine("sagol");
                //}


                //int a = 10;
                //int b = 30;

                //if (a > 5 && b < 25)
                //    Console.WriteLine("a deyeri 5-den boyukdur, b deyeri 25-den kicikdir.");


                //if(a is Int32)
                //{
                //    Console.WriteLine("a deyiseni int tipindedir");
                //}
                //else
                //{
                //    Console.WriteLine("a deyiseni int tipinde deyil");
                //}


                //string country = "Amerika";

                //if (country == "Turkiye") {
                //    Console.WriteLine("Turkiyenin paytaxti Ankara seheridir.");
                //}
                //else if (country == "Almaniya")
                //{
                //    Console.WriteLine("Almaniyanin paytaxti Berlin seheridir.");
                //}
                //else if (country == "Italiya")
                //{
                //    Console.WriteLine("Italiyanin paytaxti Roma seheridir.");
                //}
                //else if (country == "Azerbaycan")
                //{
                //    Console.WriteLine("Azerbaycanin paytaxti Baki seheridir.");
                //}
                //else if (country == "Fransa")
                //{
                //    Console.WriteLine("Fransanin paytaxti Paris seheridir.");
                //}
                //else if (country == "Hollandiya")
                //{
                //    Console.WriteLine("Hollandiyanin paytaxti Amsterdam seheridir.");
                //}
                //else
                //{
                //    Console.WriteLine("Hec bir sert odenmedi!");
                //}

                //bool test = true;
                //if (!test)
                //{

                //}

                //#region Task in Lesson 1
                ///*
                // Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. 
                //       Deyer reqemdirse ancaq 0-dan kiçik, 100-dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın. Əgər rəqəmdirsə,
                //       aralıqlara görə ekrana bir imtahan nəticəsi yazın.

                //       Bal 20-dən kiçik olarsa "İmtahandan kəsildiniz" yazın.
                //       20-dən böyük və ya bərabər, 40-dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında
                //       "Netice: qenaetbexs"
                //       40-dan böyük və ya bərabər, 60-dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"
                //       60-dan böyük və ya bərabər, 80-dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"
                //       80-a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
                // */
                //Console.OutputEncoding = Encoding.Unicode;
                //Console.InputEncoding = Encoding.Unicode;

                //string exampPointStr = Console.ReadLine();
                //int exampPoint = 0;
                //bool parsePoint = int.TryParse(exampPointStr, out exampPoint);
                ////bool test = !parsePoint;

                //if(!parsePoint)
                //    Console.WriteLine("Xahis olunur bir reqem daxil edin");
                //else if (exampPoint < 0 || exampPoint > 100)
                //    Console.WriteLine("Düzgün bal daxil edilməyib");
                //else if(exampPoint < 20)
                //    Console.WriteLine("İmtahandan kəsildiniz");
                //else if(exampPoint >= 20 && exampPoint < 40)
                //{
                //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                //    Console.WriteLine("Netice: qenaetbexs");
                //}
                //else if(exampPoint >= 40 && exampPoint < 60){
                //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                //    Console.WriteLine("Netice: kafi");
                //}
                //else if(exampPoint >= 60 && exampPoint < 80)
                //{
                //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                //    Console.WriteLine("Netice: yaxsi");
                //}else if(exampPoint >= 80)
                //{
                //    Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                //    Console.WriteLine("Netice: ela");
                //}
                //#endregion

                //var firstname = "Orkhan";
                //var surname = "Farajov";
                //var dateOfBirth = new DateTime(1995, 12, 24);
                //var job = "Developer";

                //if(firstname == "Orkhan" && surname == "Farajov")
                //{


                //    if(dateOfBirth.Year == 1995 && dateOfBirth.Month == 12 && dateOfBirth.Day == 24)
                //    {


                //        if(job == "Developer")
                //        {
                //            Console.WriteLine("Xos geldin " + firstname);
                //        }
                //        else
                //        {
                //            Console.WriteLine("Job yanlisdir!");
                //        }


                //    }
                //    else
                //    {
                //        Console.WriteLine("Dogum tarixi yanlisdir!");
                //    }


                //}
                //else
                //{
                //    Console.WriteLine("Ad ve ya Soyad yanlisdir!");
                //}


                #region Task in Lesson 2
                /*
                 Task: Kicik bir calc. app yazilacaq. Birinci istifadeciye ede bileceyi emeliyyatlari nomreyle gosterin.
                           "Etmek istediyiniz emeliyyati secin:"
                           "1. Toplama"
                           "2. Cixma"
                           "3. Vurma"
                           "4. Bolme"
                        Istifadeci emeliyyati secenden sonra a ve b deyerlerini reqem olaraq alin ve emeliyyati icra edib neticeni gosterin.
                        Sadece bir dene bolme emeliyyatinda eger b-nin deyeri 1-den kicik olarsa, ekrana
                        "Deyeri 0-a bolmek olmaz!" yazdirin.
                 */

                //Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
                //Console.WriteLine("1. Toplama");
                //Console.WriteLine("2. Cixma");
                //Console.WriteLine("3. Vurma");
                //Console.WriteLine("4. Bolme");
                //var op = Convert.ToInt16(Console.ReadLine());
                //var a1 = Convert.ToInt32(Console.ReadLine());
                //var b1 = Convert.ToInt32(Console.ReadLine());

                //if (op == 1)
                //{
                //    Console.WriteLine("Netice: " + (a1 + b1));
                //}
                //else if (op == 2)
                //{
                //    Console.WriteLine("Netice: " + (a1 - b1));
                //}
                //else if (op == 3)
                //{
                //    Console.WriteLine("Netice: " + (a1 * b1));
                //}
                //else if (op == 4)
                //{
                //    if(b1 == 0)
                //    {
                //        Console.WriteLine("Deyeri 0-a bolmek olmaz");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Netice: " + (a1 / b1));
                //    }
                //}
                #endregion
            }


            //Switch-Case
            {
                string langOrFramework = "C#";

                switch (langOrFramework)
                {
                    case "ASP.NET":
                        Console.WriteLine("Microsoft");
                        break;
                    case "F#":
                        Console.WriteLine("Microsoft");
                        break;
                    case "C#":
                        Console.WriteLine("Microsoft");
                        break;
                    case "Java":
                        Console.WriteLine("Oracle");
                        break;
                    default: //(eger hec bir case'e uygun gelmese)
                        Console.WriteLine("Hec birine uygun gelmedi");
                        break;
                }


                //(if-else versiyasi nece olardi????)
                if(langOrFramework == "ASP.NET")
                {
                    Console.WriteLine("Microsoft");
                }
                else if(langOrFramework == "F#") { 
                    Console.WriteLine("Microsoft");
                }
                else if(langOrFramework == "C#") { 
                    Console.WriteLine("Microsoft");
                }
                else if(langOrFramework == "Java") { 
                    Console.WriteLine("Oracle");
                }
                else{ 
                    Console.WriteLine("Hec birine uygun gelmedi");
                }
            }
        }
    }
}

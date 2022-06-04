using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string Country { get; set; } = "Azerbaijan";


        static void Main(string[] args)
        {
            #region Task in Lesson 1
            {
                //a, b, c
                int a = 10;
                int b = 20;
                int c = a + b;
                //Console.WriteLine(c);
            }
            #endregion

            #region Task in Lesson 2
            {
                //İki ölkə adını iki ayrı dəyişəndə saxlayın. Məsələn aze adında bir dəyişəndə Azərbaycan, tur
                //adında bir dəyişəndə isə Türkiyə dəyərini saxlayın. Sonra azeTur adlı bir dəyişəndə aze və tur dəyişənlərinin
                //birləşməsini əldə edin (aralarında boşluq olsun: Azərbaycan Türkiyə)
                string aze = "Azerbaycan";
                string tur = "Turkiye";
                string azeTur = aze + " " + tur;

                Console.WriteLine(azeTur);
                Console.ReadLine();
            }
            #endregion

            #region Char type
            {
                //hecmi: 2 byte
                //tipi: Value-Type
                //character
                string singleA = "a";
                char single_A = 'a';

                string a = "A";
                string b = "B";
                string c = "C";
                string d = "D";
                string e = "E";
                string f = "F";
                string g = "G";
                string h = "H";

                char charA = 'A';
                char charB = 'B';
                char charC = 'c';
                char charD = 'D';
                char charE = 'E';
                char charF = 'F';
                char charG = 'G';
                char charH = 'H';

                char symbol = '*';
                char whiteSpace = ' ';
                char question = '?';

                char toLower = char.ToLower(charA);
                char toUpper = char.ToUpper(charC);
                bool isLower = char.IsLower(toLower);
                bool isUpper = char.IsUpper(toLower);

                bool isNumber = char.IsNumber(charA);
                bool isLetter = char.IsLetter(charA);
                bool isDigit = char.IsDigit(charA);
                bool isWhiteSpace = char.IsWhiteSpace(charA);

            }
            #endregion



            #region Byte Type
            {
                //hecmi: 1 byte
                //deyer araligi: 0 --- 255
                //tipi: Value-Type

                byte byteVariable = 45;
                byte byteMinValue = byte.MinValue;
                byte byteMaxValue = byte.MaxValue;
            }
            #endregion



            #region Double Type
            {
                //hecmi: 8 byte
                //precision: 15-16
                //deyer araligi: -1.7976931348623157E+308   ---   1.7976931348623157E+308
                //tipi: Value-Type

                double doubleVar = 10.2;
                double doubleVar2 = 25;
                double doubleVar3 = 45.8D;

                double doubleMinValue = double.MinValue;
                double doubleMaxValue = double.MaxValue;

                double nan = 0.0 / 0.0; //NaN - Not a Number
                double notNan = 5 / 2.5;
                bool resultOfNan = double.IsNaN(nan);
                bool resultOfNotNan = double.IsNaN(notNan);

                double infinity = 0.1 / 0.0;
                double notInfinity = 0.0 / 0.0;
                bool resultOfInfinity = double.IsInfinity(infinity);
                bool resultOfNotInfinity = double.IsInfinity(notInfinity);

                double epl = double.Epsilon;
                double epilsonValue = 4.94065645841247E-324;
                double one = 0.1;

                bool whichIsGreater = 0.1 > epl;
            }
            #endregion



            #region Task in Lesson 3
            /*
              5 dene deyiseniniz olacaq. Men deyerlerini asagida yaziram siz o deyerlere uygun data tipinde saxlayin.
              1. true
              2. 'A'
              3. 5 (amma RAM'i nezere alin)
              4. salam
              5. 999999999999999999 (18 dene 9 reqemi)
             */
            bool _1 = true;
            char _2 = 'A';
            byte _3 = 5;
            string _4 = "salam";
            double _5 = 999999999999999999;
            #endregion


            #region Decimal Type
            {
                //hecmi: 16byte
                //precision: 28-29
                //deyer araligi: -79,228,162,514,264,337,593,543,950,335   ---   79,228,162,514,264,337,593,543,950,335
                //tipi: Value-Type

                decimal decimalVar = 10.2M;

                decimal decimalMinValue = decimal.MinValue;
                decimal decimalMaxValue = decimal.MaxValue;

                decimal minusOneValue = decimal.MinusOne;

                //byte decimalToByte = decimal.ToByte(100000000); //xeta
                //sbyte decimalToSByte = decimal.ToSByte(100000000); //xeta
                decimal dec = 500;

                short decimalToShort = decimal.ToInt16(dec);
                int decimalToInt = decimal.ToInt32(2226262);
                long decimalToBigInt = decimal.ToInt64(25615616515615);
            }
            #endregion


            #region Float Type
            {
                //hecmi: 4 byte / 32 bit
                //precision: 7 reqem
                //deyer araligi: -3.40282347E+38   ---   3.402823466E+38
                float floatVar = 10.5F;

                float floatMinValue = float.MinValue;
                float floatMaxValue = float.MaxValue;
            }
            #endregion


            #region DateTime Type
            {
                //hecmi: 8 byte
                //deyer araligi: 1/1/0001 --- 12/31/9999

                DateTime now = DateTime.Now; //(Local time)
                DateTime utcNow = DateTime.UtcNow; //(UTC = coordinated universal time)

                long ticks = now.Ticks;
                int milliSeconds = now.Millisecond;
                int seconds = now.Second;
                int minute = now.Minute;
                int hour = now.Hour;
                int day = now.Day;
                DayOfWeek dayOfWeek = now.DayOfWeek;
                int month = now.Month;
                int year = now.Year;
                TimeSpan timeOfDay = now.TimeOfDay;
                string shortDateString = now.ToShortDateString();
                string longDateString = now.ToLongDateString();
                string shortTimeString = now.ToShortTimeString();
                string longTimeString = now.ToLongTimeString();
                string timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
                string timeFormat1 = now.ToString("MMMM dd");
                string timeFormat2 = now.ToString("dddd, dd MMMM yyyy");
                string timeFormat3 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                string timeFormat4 = now.ToString("HH:mm");
                string timeFormat5 = now.ToString("h:mm");
                string timeFormat6 = now.ToString("ddd, dd-MMM-yyy HH:mm:ss.fffffff");
                string timeFormat7 = now.ToString("ddd.K");


                DateTime monthChanged = now.AddMonths(2);
                DateTime dayChanged = now.AddDays(2);
                DateTime hourChanged = now.AddHours(2);
                DateTime minuteChanged = now.AddMinutes(2);
                DateTime secondChanged = now.AddSeconds(2);
                now = now.AddDays(5);

                string changedTime = minuteChanged.ToString("HH:mm");

                DateTime specificDate = new DateTime(1990, 12, 25);
                DateTime specificDateAndTime = new DateTime(1995, 12, 24, 10, 05, 59, 100/*millisecond*/);
            }
            #endregion



            #region Object Type
            {
                //hecmi: 4 byte
                //deyer araligi: butun C# tipleri/obyektleri
                //tipi: Referance-Type
                int a = 5;
                object b = a;

                string by = "sagol";
                object by_object = by;

                object stringVar = "salam";
                object integerVar = 15615;
                object boolVar = true;
                object charVar = '%';
                object dateTimeVar = new DateTime();
                object studentObj = new Student();
            }
            #endregion

            #region Task in Lesson 4
            {
                /*
                 decimal, double, float tiplerinde deyisenleriniz olacaq. Deyerleri 10.5 - 20.5 - 30.5 olacaq.
                 */
                double d1 = 10.5;
                decimal d2 = 20.5M;
                float f3 = 30.5F;
            }
            #endregion





            #region Assign one to another
            string orkhan = "Orkhan Farajov";
            string john = "John Farajov";

            orkhan = john;
            john = orkhan;

            orkhan = "hello";
            john = "hi";

            int fiveHundred = 500;
            int fiveHundredCopied = fiveHundred;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            isWinterCold = false;

            char p = 'P';
            char pCopied = p;
            #endregion


            #region Task in Lesson 5
            //Iki dene deyiseniniz olacaq. Biri indiki tarixi, digeri ise 20 12 2020-ci ili saxlayacaq.
            DateTime _now = DateTime.Now;
            DateTime _spDate = new DateTime(2020, 12, 20);
            #endregion



            #region Default values of data types
            //referance types
            string defaultString;
            object defaultObject;
            Student student;

            //value-types
            char charDefault;
            byte byteDefault;
            short shortDefault;
            int intDefault;
            long longDefault;
            double doubleDefault;
            decimal decimalDefault;
            float floatDefault;
            bool boolDefault;
            DateTime dateTimeDefault; //ilk gunu goturur
            #endregion


            #region Local vs Global variables
            Console.WriteLine(Country);

            ShowCountry();
            
            int myLocalVariable = 5;
            Console.WriteLine(myLocalVariable);


            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }

            Console.WriteLine(globalVar);


            //Level 5 - Butun skoplara gore global ve el catan (Main method'unun skopu icinde)
            int level5 = 500;
            //level4 -= 100; //level4 does not exist
            //level3 -= 100; //level3 does not exist
            //level2 -= 100; //level2 does not exist
            //level1 -= 100; //level1 does not exist
            {
                //Level 4 - Alt skoplara gore global, ust skoplara gore local
                int level4 = 400;

                level5 -= 100;
                //level3 -= 100; //level3 does not exist
                //level2 -= 100; //level2 does not exist
                //level1 -= 100; //level1 does not exist
                {
                    //Level 3 - Alt skoplara gore global, ust skoplara gore local
                    int level3 = 300;

                    level5 -= 100;
                    level4 -= 100;
                    //level2 -= 100; //level2 does not exist
                    //level1 -= 100; //level1 does not exist

                    {
                        //Level 2 - Alt skoplara gore global, ust skoplara gore local
                        int level2 = 200;

                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        //level1 -= 100; //level1 does not exist

                        {
                            //Level 1 - tamamile local deyisen
                            int level1 = 100;

                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                        }
                    }
                }
            }


            int globalAge;

            {
                int localAge = 27;
                globalAge = localAge;
            }

            {
                int myAge;
                myAge = globalAge;
            }
            //end
            #endregion
        }
        
        public static void ShowCountry()
        {
            Console.WriteLine(Country);
        } 
    }
}

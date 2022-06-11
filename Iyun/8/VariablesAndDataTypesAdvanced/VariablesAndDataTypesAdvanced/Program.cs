using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple form app
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Unicode consortium organization

            Console.WriteLine("Salam xoş gəlmisiniz");

            Console.WriteLine("Adınızı daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı daxil edin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Doğulduğunuz ölkəni daxil edin: ");
            string country = Console.ReadLine();

            Console.WriteLine("Boyunuzu daxil edin: ");
            string height = Console.ReadLine();

            Console.WriteLine("Çəkinizi daxil edin: ");
            string weight = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Ölkə: " + country);
            Console.WriteLine("Boy: " + height);
            Console.WriteLine("Çəki: " + weight);
            #endregion

            #region Task in Lesson 1
            /*
             Task details:
             Kiçik bir anket app'ı hazırlayın. İlk öncə istifadəçiyə "Xoş gəldiniz!" mesajı göstərin. Növbəti sətirdə adını soruşun.
             Adını daxil etdikdən sonra, ona necə müraciət edəcəyini soruşun. Məsələn adını Orxan, müraciət qaydasını bəy olaraq
             yazdısa, növbəti suallar belə olacaq:
             1. Orxan bəy neçə yaşınız var?
             2. Orxan bəy hansı sahədə işləyirsiniz?
             3. Orxan bəy ən son nə zaman kitab oxumusunuz?
             4. Orxan bəy sevdiyiniz rəng hansıdır?
             5. Orxan bəy avtomobil idarə edə bilirsiniz?
             6. Orxan bəy gündə neçə saat yatırsınız?
             7. Orxan bəy TV kanallarını izləyirsiniz?

             Əgər istifadəçi müraciət qaydası olaraq bəy/xanım daxil etməsə o zaman birbaşa Orxan neçə yaşınız var? soruşsun.
             */

            string name1 = Console.ReadLine();
            string msMr = Console.ReadLine();
            Console.WriteLine(name1 + " " + msMr + " neçə yaşınız var?");

            string age = Console.ReadLine();
            #endregion



            #region Type Conversion

            #region Implicit Type Conversion
            //Nümunə 1:
            byte byteVal = byte.MaxValue; //255
            short shortVal = short.MaxValue; //32767
            short takeByteVal = byteVal; //(implicit conversion)
            //byte takeShortVal = shortVal;

            //Nümunə 2:
            int takeShortVal = shortVal; //(implicit conversion)

            //Nümunə 3:
            int takeBtVal = byteVal; //(implicit conversion)

            //Nümunə 4:
            int i = 5000;
            long l = i;

            long l2 = 5000000;
            float f = l2;

            float f2 = 2545156.6f;
            double d = f2;

            //byte test = Convert.ToByte(i);
            //Ardicilliq: byte -> short -> int -> long -> float -> double
            byte aaa = 100;
            short bbb = 200;
            int ccc = 300;
            long ddd = 400;
            float fff = 500;
            double ggg = fff;
            #endregion



            #region Signed - Unsigned data types
            //Unsigned data types
            byte us1 = byte.MinValue; //8-bit
            ushort us2 = ushort.MinValue; //16-bit
            ushort us21 = ushort.MaxValue;
            uint us3 = uint.MinValue; //32-bit
            ulong us4 = ulong.MinValue; //64-bit

            //Signed data types
            sbyte s1 = sbyte.MinValue;
            short s2 = short.MinValue;
            short s21 = short.MaxValue;
            int s3 = int.MinValue;
            long s4 = long.MinValue;

            //unsigned ushort deyer araligi: 0 - 65535
            //signed short deyer araligi: -32.768 - 32767
            //32767 - 65535 = -32768.
            #endregion


            #region Explicit Type Conversion
            //Explicit Type Conversion xətası alacağımız nümunələr:
            int a = 20000;
            //short b = a;

            double c = 785.22;
            //float d1 = c;

            short e = 10;
            //ushort f1 = e;

            float g = 15.5F;
            //long j = g;

            long l1 = 1000000000;
            //int o = l1;



            //Explicit Type Conversion üçün nümunələr:
            int a1 = 20000;
            short b1 = (short)a1;

            double c1 = 785.22;
            float d1 = (float)c1;

            short e1 = 10;
            ushort f1 = (ushort)e1;

            float g1 = 15.5F;
            long j1 = (long)g1;

            long l3 = 1000000000;
            int o1 = (int)l3;

            int ch = 1;
            char ch1 = (char)ch; //'1'
            //Yazılış qaydası: hedefType a = (hedefType)qaynaqType

            //Ardıcıllıq double -> float -> long -> int -> char
            #endregion


            #region Checked & Unchecked keywords
            //Casting without checked keyword
            long longVar = Convert.ToInt64(Console.ReadLine()); //9999999999
            int takeLongVar = (int)longVar;

            short shortVar = Convert.ToInt16(Console.ReadLine()); //30000
            byte takeShortVar = (byte)shortVar;

            checked
            {
                long longVariable = Convert.ToInt64(Console.ReadLine()); //9999999999
                int takeLongVariable = (int)longVariable;
            }

            checked
            {
                int money = Convert.ToInt32(Console.ReadLine()); //100000=error / 10=success
                short takeInt = (short)money;

                unchecked
                {
                    byte age1 = Convert.ToByte(Console.ReadLine()); //200
                    sbyte takeByte = (sbyte)age1;
                }
            }
            #endregion

            #region Helper Class Conversion
            string numberString = "50";
            int number;

            //Implicit Conversion numunesi:
            //number = numberString; //(Cannot implicitly convert type string to int)

            //Explicit Conversion numunesi:
            //number = (int)numberString; //(Cannot convert type string to int)

            //Helper Class Conversion numunesi:
            number = Convert.ToInt32(numberString);

            //Not possible:
            //bool booleanVariable = 1;
            //bool booleanVariable = (bool)1;
            //int integerVariable = (int)"1";
            //int integerVariable = (int)true;

            //Possible:
            bool booleanVariable;
            booleanVariable = Convert.ToBoolean(1); //true
            booleanVariable = Convert.ToBoolean("true"); //true
            booleanVariable = Convert.ToBoolean(null); //false

            int integerVariable;
            integerVariable = Convert.ToInt32("10"); //10
            integerVariable = Convert.ToInt32(null); //0
            integerVariable = Convert.ToInt32(true); //1
            integerVariable = Convert.ToInt32(false); //0

            string numString = "45";
            //short stringToShort = numString;
            //short stringToShort = (short)numString;
            short stringToShort = Convert.ToInt16(numString);
            
            //int stringToInt = numString;
            //int stringToInt = (int)numString;
            int stringToInt = Convert.ToInt32(numString);

            //long stringToLong = numString;
            //long stringToLong = (long)numString;
            long stringToLong = Convert.ToInt64(numString);

            //Source variable types
            int intVariable = 10;
            long longVariable1 = 999999999;
            short shortVariable = 1000;
            byte byteVariable = 150;
            bool boolVariable = true;

            //Destination string variable
            string getAnyValue;
            getAnyValue = intVariable.ToString();
            getAnyValue = longVariable1.ToString();
            getAnyValue = shortVariable.ToString();
            getAnyValue = byteVariable.ToString();
            getAnyValue = boolVariable.ToString();

            bool _boolVariable = Convert.ToBoolean("false"); //false
            byte _byteVariable = Convert.ToByte("10");
            char _charVariable = Convert.ToChar("A");
            DateTime _dateTimeVariable = Convert.ToDateTime("2020-12-12");
            decimal _decimalVariable = Convert.ToDecimal("15.7");
            double _doubleVariable = Convert.ToDouble("15.5");
            short _shortVariable = Convert.ToInt16("-25015");
            int _intVariable = Convert.ToInt32("1500000");
            long _longVariable = Convert.ToInt64("2000000021");
            sbyte _sbyteVariable = Convert.ToSByte("12");
            ushort _uShortVariable = Convert.ToUInt16("20");
            uint _uIntVariable = Convert.ToUInt32("20");
            ulong _uLongVariable = Convert.ToUInt64("20");
            #endregion

            #region User-Defined Conversion
            Student student = new Student("Orkhan", "Farajov", 27);
            string strStudent = student;
            string strStudentCast = (Student)student;
            string strStudentToString = student.ToString();
            #endregion
            #endregion
            Console.ReadLine();
        }
    }
}

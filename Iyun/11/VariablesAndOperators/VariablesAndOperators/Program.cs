using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            {
                //Boxing
                //Implicit
                int valueType = 100; //stackda saxlanildi
                object referanceType = valueType;

                //Explicit
                object otherValue = (object)valueType;

                //Unboxing
                int a = 100;
                object o = a;
                int unboxing = (int)o;

                int b = 100;
                object o1 = b;
                //int err = (byte)o1;
            }
            #endregion


            #region Convert, Parse and TryParse
            {
                string textNumber = "100";

                //With convert
                int convertToInt = Convert.ToInt32(textNumber);

                //With Parse method
                int parseToInt = int.Parse(textNumber);

                //With TryParse method
                int integerValue;

                string notNumberString = "5Salam";
                bool badResult = int.TryParse(notNumberString, out integerValue); //0 default value

                string numberString = "5";
                bool goodResult = int.TryParse(numberString, out integerValue); //5 parse result
            }
            #endregion


            #region Task in Lesson 1
            /*
             Task: boolean tipinde bir deyiseniniz olsun deyeri de true olsun. Bir dene de int tipinde deyisen yaradib deyerini
                   1 verirsiniz. Bu int deyisenine deyeri 1 set edenden sonra, ele edin ki, boolean tipinde deyiseni necese 
                   konvertasiya edib 0 deyerini elde edesiniz. Convert, Parse ve ya TryParse'dan istifade etmelisiniz.
             */
            bool booleanVar = true;
            string stringVar = booleanVar.ToString();
            int resultOfTryParse = 1;
            bool parse = int.TryParse(stringVar, out resultOfTryParse);
            int result = Convert.ToInt32(parse);
            #endregion

            string nullString = null;
            int nullConvertResult = Convert.ToInt32(nullString); //0
            //int nullParseResult = int.Parse(nullString); //xeta
            int nullOutVal = 2;
            bool tryToParseNull = int.TryParse(nullString, out nullOutVal);

            string notIntString = "A";
            //int notIntConvertResult = Convert.ToInt32(notIntString); //xeta
            //int notIntParseResult = int.Parse(notIntString); //xeta
            int notIntOutVal = 2;
            bool tryToParsenotInt = int.TryParse(notIntString, out notIntOutVal);


            #region Task in Lesson 2
            /*
             Task 1: iki int tipinde deyisen yaradin 1 ve 0 deyerle. Basqa 2 dene bool tipinde deyisenin deyerlerini,
                     hemin o int tipinde deyisenin deyerlerinden yaradin.
             */
            int falseVal = 0;
            int trueVal = 1;
            //bool falseBool = falseVal;     //(Cannot implicitly convert type 'int' to 'bool'.)
            //bool trueBool = trueVal;       //(Cannot implicitly convert type 'int' to 'bool'.)
            //bool trueBool = (bool)trueVal; //(Cannot convert type int to bool.)
            bool trueBool1 = Convert.ToBoolean(trueVal);
            bool falseBool1 = Convert.ToBoolean(falseVal);


            /*
             Task 2: Bir dene datetime tipinde deyiseniniz olsun ve indiki zamani goturun. Sonra o deyiseni bir basqa 
                     object tipindeki deyisene menimsedin (boxing). Sonra datetime tipinde 3-cu bir deyisen yaradin ve
                     2-ci yaratdiginiz objectin deyerini 3-cu yaratdiginiz datetime'a verin.
             */
            DateTime now = DateTime.Now;
            object objDate = now;
            DateTime dateFromObject = Convert.ToDateTime(objDate);


            /*
             Task 3: iki string tipinde deyisende True ve False sozlerini saxlayin. Sonra bu stringleri bool tipinde bir deyisene
                     cevirin. Convert'den istifade etmek olmaz.
             */
            string trueText = "True";
            bool trueFromString = bool.Parse(trueText);

            string falseText = "False";
            bool falseFromString = bool.Parse(falseText);
            #endregion



            #region Constant
            double pi = 3.14;
            //bir ay kecdi
            pi = 5.20;

            const double piConst = 3.14;
            //bir ay kecdi
            //piConst = 5;

            int no; //burda teyin etdim
            no = 100; //deyerini burda verdim

            string name;
            name = "Orkhan";
            name = "Tural";

            DateTime dt;
            dt = DateTime.Now;

            //const int aa; //deyer vermeden teyin etmek olmaz!
            const int number = 500; //deyeri de yazilmalidir (mecburdur)
            //const int buildingNo = no; //const, ancaq const deyer qebul edir
            const int buildingNo = number;
            #endregion


            #region Var
            int numberOne = 1;
            string text = "Hello";
            decimal dec = 45.5M;
            double dob = 45.5;
            DateTime dt1 = DateTime.Now;
            char ch = '2';
            long l = 999999999999;
            short s = 1000;

            var numberOneVar = 1;
            var textVar = "Hello";
            var decVar = 45.5M;
            var dobVar = 45.5;
            var dt1Var = DateTime.Now;
            var chVar = '2';
            var lVar = 999999999999;
            var sVar = 1000;

            var i1 = 100;
            //i = "salam"; //implicit xetasi

            var dbl = 100.5D;
            //dbl = true; //implicit xetasi

            var dtt = DateTime.Now;
            //dtt = '5'; //implicit xetasi

            //IL = Intermediate Language
            //var test = null;
            //(var keyworduyle yaradilan deyisene null deyer verile bilmez cunku tipi mueyyenlesdirile bilmeyecek)
            //(type inferance)

            object objectVariable = 100;
            objectVariable = "skanm";
            objectVariable = 45.2D;
            objectVariable = 'A';
            objectVariable = DateTime.Now;

            int seeIntMethods = 5;
            string seeStringMethods = "salam";
            object obj = seeIntMethods;
            object obj1 = seeStringMethods;

            int number1, number2, number3;
            string firstname, surname, fathername;
            DateTime startDate, endDate;
            int no1, no2 = 40;
            #endregion


            #region Operators
            /*
             Qeyd:
             1. Unary: a++, b--, !true;
             2. Binary: a + b, a > b, a = b;
             3. Ternary: a > b ? "" : "" (shorthand if else)
             Operator nədir?: +, -, *, !, !=
             Operand nədir?: a, b, c (dəyişən və s.)

             Qeyd:
             1. Arithmetic (hesablama)     ++, --, +, -, *, /, %
             2. Logical    (məntiqi)       !, ||, && 
             3. Special    (xüsusi)        sizeof, typeof, new, checked, unchecked, as, is
             4. Assignment (mənimsəmə)     =, +=, -=, /=, *=, %=
             5. Comparsion (qarşılaşdırma) >, <, ==, !=, <=, >=
             6. Bitwise
             */

            decimal x = 100;
            decimal y = 5;
            decimal i = 0;

            //Arithmetic (hesablama)
            i = x + y;
            i = x - y;
            i--; //(i = i - 1) ilə eynidir
            i++; //(i = i + 1) ilə eynidir
            i = i - 1;
            i = i + 1;
            i -= 5; //(i bərabərdir i çıx 5)
            i += 5; //(i bərabərdir i üstəgəl 5)
            i = x--; //(x-dən 1 çıx, i-yə mənimsət. Burada x'in də dəyəri azalmış olur)
            i = y * 5;
            i = x / 5; //(cavab 5.1, 5.5 və ya 5.9 belə olsa belə, əgər bölən-bölünən int tipindədirsə cavab 5 olacaq yəni aşağı round olacaq.)
            i = x * y;
            i = x / y;
            i = x % y; //(modul)
            int m = 10 % 2; //(cavab 0 olacaq)
            m = 11 % 2; //(cavab 1 olacaq)
            string country = "Azerbaijan";
            string city = "Baki";
            string address = country + " " + city;



            //Logical (məntiqi)
            bool trueBool = true, falseBool = false, res;
            res = !trueBool;
            res = !falseBool;
            res = !falseBool || !trueBool;
            res = !falseBool && !trueBool;
            res = 5 == 5;



            //Assignment (mənimsəmə) - (bir dəyişənə dəyər mənimsətmək üçün istifadə olunur)
            int assign = 100;
            assign += 5; //(assign = assign + 5)
            assign -= 5; //(assign = assign - 5)
            assign /= 5; //(assign = assign / 5)
            assign *= 5; //(assign = assign * 5)
            assign %= 2; //(assign = assign % 2)
            string person = "Orkhan Farajov";
            person += " is developer";



            
            //Comparsion (qarşılaşdırma)
            int c = 100;
            int d = 5;
            string name1 = "Orkhan";
            string name2 = "John";

            bool compareRes = false;
            compareRes = c > d;
            compareRes = c < d;
            compareRes = c == d;
            compareRes = c != d;
            compareRes = c <= d;
            compareRes = c >= d;
            compareRes = name1 == name2;
            //compareRes = name1 == x; //(string və int tipində operandlar qarşılaşdırıla bilməz)
            res = (10 / 2) == 5;
            res = (10 / 2) != 5;


            //Special (xususi) sizeof, typeof, new, checked, unchecked, as, is
            int sizeOf = sizeof(sbyte);
            sizeOf = sizeof(byte);
            sizeOf = sizeof(Int16);
            sizeOf = sizeof(short);
            sizeOf = sizeof(Int32);
            sizeOf = sizeof(int);
            sizeOf = sizeof(ulong);
            sizeOf = sizeof(long);
            sizeOf = sizeof(uint);
            //sizeOf = sizeof(string); //xeta verecek cunku referance type'larin byte olcusunu sizeof'la hesablamaq olmur.


            Type type1 = typeof(int);
            Type type2 = typeof(Int32);
            bool compareIntAndInt32 = type1 == type2;

            Type type3 = typeof(int);
            Type type4 = typeof(bool);
            bool compareIntAndBool = type3 == type4;

            DateTime dt5 = new DateTime();

            //is
            int otherInt = 25;
            bool isOtherInt_String = otherInt is string;
            bool isOtherInt_Int = otherInt is int;
            bool isOtherInt_Int32 = otherInt is Int32;
            bool isOtherInt_Int64 = otherInt is Int64;

            //as
            object objectName = "Orkhan";
            object objectNum = 5;
            string sName = objectName as string;
            string sText = objectNum as string;
            //int aaa = sName as int;




            //Operator onceliyi
            //10 * 20 / 5 = 40
            float u = 10 * 20 / 5;
            float u1 = (10 * 20) / 4;
            #endregion
        }
    }
}

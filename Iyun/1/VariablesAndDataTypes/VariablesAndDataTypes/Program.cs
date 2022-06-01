using System;

namespace VariablesAndDataTypes
{
    class Programg
    {
        static void Main(string[] args)
        {
            #region What is Data Type
            //string a = "5";
            //int b = 5;

            //string c = "Salam";
            //int d = "salam"; //error verecek


            /*
             Byte hesablama dusturu:
             1 byte = 8 bit
             Int16 tipi 16 bit'dir. - 16 bit / 8 bit = 2 byte
             Int32 tipi 32 bit'dir. - 32 bit / 8 bit = 4 byte
             Int64 tipi 64 bit'dir. - 64 bit / 8 bit = 8 byte
             */

            /*
             Value-Type data tipleri:
             bool
             byte
             char
             deciaml
             double
             enum
             float
             int
             long
             sbyte
             short
             struct
             uint
             ulong
             ushort

             Referance-Type data tipleri:
             String/string
             Arrays
             Class
             Delegate
             
             */
            int age;
            bool myBool;
            decimal myDecimal;

            string name;
            #endregion



            #region Practise with data types

            #region Boolean type
            //Hecmi: 1 bit
            //Deyer Araligi: true --- false
            //Tipi: Value-Type
            //True he cavabini temsil edir, false ise yox cavabini temsil edir.

            bool booleanVar = true;
            booleanVar = false;

            bool otherBooleanVar; //default deyer: false
            otherBooleanVar = true;

            string falseString = bool.FalseString; //False
            string trueString = bool.TrueString; //True
            string myFalseString = "False";
            #endregion

            #region String Type
            //Hecmi: Her bir xarakter ucun 1 byte
            //Deyer Araligi: yoxdur
            //Tipi: Referance-Type

            string name_ = "Orkhan"; //RAM'da 6 byte yer tutacaq
            Console.WriteLine(name_);

            string surname = "Farajov"; //RAM'da 7 byte yer tutacaq
            Console.WriteLine(surname);

            string nameSurname = "Orkhan Farajov"; //RAM'da 14 byte yer tutacaq

            //Butun herfleri boyuk herfe cevirmek
            string upperNameSurname = nameSurname.ToUpper();

            //Butun herfleri kicik herfe cevirmek
            string lowerNameSurname = nameSurname.ToLower();

            string subString = nameSurname.Substring(1, 5);

            //C herfi ile baslayib baslamamasini yoxlayir ve true/false olaraq deyer qaytarir.
            bool startsWith_C = nameSurname.StartsWith("C");
            bool startsWith_o = nameSurname.StartsWith("o");
            bool startsWith_O = nameSurname.StartsWith("O");

            //G herfi ile bitib bitmemesini yoxlayir ve true/false olaraq deyer qaytarir.
            bool endsWith_G = nameSurname.EndsWith("G");
            bool endsWith_v = nameSurname.EndsWith("v");

            //stringin uzunlugunu reqem olaraq qaytarir
            int length = nameSurname.Length;

            //0 daxil olmaqla herfin oldugu index'i qaytarir
            int indexOf = nameSurname.IndexOf("n");

            //deyisenin deyerinin, equals method'una oturulen parametrdeki deyerle eyni olub olmamasini
            //yoxlayib true/false olaraq netice qaytarir
            bool equals = nameSurname.Equals("Orkhan Farajov");
            bool equals_1 = nameSurname.Equals("Orkhan farajov");
            bool equals_2 = nameSurname.Equals("Orkhan Mahmudov");
            #endregion

            #region Short, Int, Long Types
            //Hecmi:
                //Int16: 2 byte
                //Int32: 4 byte
                //Int64: 8 byte
            //Deyer Araligi:
                //Int16 bit ucun: -32,768  --- 32,767
                //Int32 bit ucun: -2147483648  --- 2147483647
                //Int64 bit ucun: -9,223,372,036,854,775,808  --- 9,223,372,036,854,775,807
            //Tipi:
                //Value-Type
            
            //short = Int16
            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortValue = 18262;
            short shortValueNegative = -1562;
            
            //int = Int32
            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            int intValue = 2458484;
            int intValueNegative = -1561561;
            
            //long = Int64
            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 4989468489486468486;
            long longValueNegative = -814514514515185458;

            int integer = 500;
            string intToString = integer.ToString();
            #endregion
            #endregion
        }
    }
}

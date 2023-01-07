using System;

namespace Static
{
    public class EmailHelper
    {
        public EmailHelper() //Constructor method
        {

        }

        public static void SendWelcomeEmail(string receiver)
        {
            Console.WriteLine("Bu method'da xos geldiniz emaili gonderilir...");
        }

        public static void SendPasswordChangeEmail(string receiver)
        {
            Console.WriteLine("Bu method'da sifre deyisdirildi emaili gonderilir...");
        }
        
        //public static int GetEmailCount()
        //{
        //    Console.WriteLine("Bu method'da sifre deyisdirildi emaili gonderilir...");
        //    return 100;
        //}

        public void NonStaticMethod()
        {

        }
        public int NonStaticProperty { get; set; }
    }
}

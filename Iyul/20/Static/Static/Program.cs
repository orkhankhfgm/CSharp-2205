using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Recursive method
            int faktorial10 = Faktorial(10);
            int faktorial0 = Faktorial(0);
            int faktorial5 = Faktorial(5);
            #endregion

            #region What is static
            Student student;
            //student.Name = "Orkhan"; //(error)

            Student.Test1();

            student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf@gmail.com";
            student.Test();
            #endregion

            #region Where and why to use static keyword?
            //1. Helper class'lar
            //2. Static field
            //3.
            //4.
            #endregion

            #region Task in Lesson 1
            /*
             Task description:
                Bir method'unuz olsun hansı ki, ad və soyad'ın uzunluğunu check edir. Əgər ad soyad 20 simvoldan uzundursa O. Fərəcov, deyilsə Orxan Fərəcov
                return edəcək.
             */
            var normalName = StringHelper.CheckFullname("Orkhan", "Farajov");
            var longFullname = StringHelper.CheckFullname("OrkhanOrkhanOrkhan", "Farajov");
            var longFullname2 = StringHelper.CheckFullname("Orkhan Middlename", "Farajov");
            var longFullname3 = StringHelper.CheckFullname("Orkhan Ibn Khayyam", "Farajov");
            #endregion

            #region Task in Lesson 2
            /*
             Task description:
                Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun. Ancaq email property'sini set edən zaman sadəcə
                @ işarəsinə qədər olan hissə set ediləcək. Yəni məsələn orkhan.farajov
                @ işarəsi və domain set olunmayacaq. Ancaq mən o class'dan istifadə edib bir işçi yaradandan sonra email ünvanını set edib alt sətirdə
                email'i get edəndə email'də @ işarəsi və domain də olacaq. Bunu edəndə encapsulation'a uyğun edin.
             */
            Staff st = new Staff();
            st.Name = "Orkhan";
            st.Surname = "Farajov";
            st.Email = "orkhan.farajov";
            st.Gender = 1;

            var email = st.Email;

            Staff st1 = new Staff();
            st1.Name = "Receb";

            Staff st2 = new Staff();
            st2.Name = "Ruslan";


            var ruslan = st2.Name;
            var receb = st1.Name;
            #endregion

        }

        #region Faktorial method
        static int Faktorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Faktorial(num - 1);
        }
        #endregion
    }
}

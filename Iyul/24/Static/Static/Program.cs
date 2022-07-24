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

            #region Task in Lesson 3
            /*
             Task description:
                İndi belə bir şey edirsiz ki, fərz edin mən staff yaradandan sonra istəyirəm ki, həmin işçiyə xoş gəlmisiniz və şifrə
                dəyişdirmə maili göndərim. Yəni sistemə yeni bir işçi əlavə olunanda həm xoş gəldiniz maili getsin həm də yeni bir
                şifrə daxil etməsi üçün link göndərilsin. İki email gedəcək burda. Bunu da bir çox yerdə istifadə edəcəyimi nəzərə alıb
                edin sonra mən yazacam. Email falan göndərməyinizə ehtiyyac yoxdur ekrana xoş gəldiniz emaili göndərildi və şifrə
                emaili göndərildi yazsa kifayətdir.
             */
            
            Staff stf = new Staff();
            stf.Name = "Orkhan";
            stf.Surname = "Farajov";
            stf.Email = "orkhan";
            stf.Gender = 1;

            EmailHelper.SendWelcomeEmail(stf.Email);
            EmailHelper.SendPasswordChangeEmail(stf.Email);
            //var test = EmailHelper.GetEmailCount();
            //Console.WriteLine(test);
            #endregion

            #region Constructor of static class
            //Helper helper = new Helper(); //Static class olduğu üçün instance yaradıla bilməz
            Helper.SayHi();
            Console.Clear();

            Employee emp = new Employee();
            emp.Name = "Orkhan";
            emp.Surname = "Farajov";
            emp.Email = "orkhan";

            Employee emp2 = new Employee();
            emp2.Name = "Orkhan";
            emp2.Surname = "Farajov";
            emp2.Email = "orkhan";

            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
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

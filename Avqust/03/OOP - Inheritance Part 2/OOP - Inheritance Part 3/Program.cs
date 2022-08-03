namespace OOP___Inheritance_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sealed class
            /*
             object => Person =>
                                 Employee
                                 Student X
                                 Teacher X
             */

            Test test = new Test();
            //test.
            #endregion

            #region Protected access modifier
            /*
              public: istər proyektin içindən və ya kənarından obyekti əlçatan edir.
              private: bir property'ni və ya bir method'u private təyin etdiyimiz zaman ancaq olduğu class daxilində istifadə edə bilərik.
              protected: protected normalda private kimi davranır. Yəni bir method və ya property'ni protected etsəm, onu ancaq class
                         daxilində istifadə edə bilərəm. Ancaq həmin class'dan bir başqa class miras alarsa, o zaman miras alan class
                         üçün public kimi davranır. Bir class nə private, nə də protected təyin edilə bilməz. Ancaq class daxilindəki
                         memberlərə aiddir.
             */
            Person person = new Person();
            person.Test();
            #endregion
        }
    }
}

using System;

namespace Encapsulation
{
    internal class Student
    {
        #region Use Auto Property Warning
        public string Name;
        public string Surname;
        private string email;

        public string Email {
            set {
                if (value.Length > 15)
                    this.email = value;
                else
                    this.email = "";
            }
            get {
                return this.email;
            }
        }
        #endregion


        #region Id Generator
        int id;

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        private int GenerateId()
        {
            Random rand = new Random();
            return rand.Next(000000, 999999);
        }

        public Student()
        {
            this.id = GenerateId();
        }
        #endregion


        /*
         Task in Lesson 1:
         Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.
         Hər biri üçün, getter və setteri olan bir property'si və private bir field'ı olacaq.
         Validation və xəta mesajları:
         Vəsiqənin seriyasını set edən zaman yoxlamalıdır ki, uzunluğu 2 hərfdir mi?
         Deyilsə: "Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!" xətası çıxmalıdır.
         Eyni zamanda yoxlamalıdır ki, sadəcə hərflərdən mi ibarətdir?
         Deyilsə: "Vesiqenin seriyasi sadece herflerden ibaret olmalidir!" xətası çıxmalıdır.
         Eyni zamanda da, vəsiqənin nömrəsi set olunan zaman baxmalıdır ki, uzunluğu 8 ə bərabərdir mi?
         Deyilsə: "Vesiqenin nomresinin uzunlugu 8 olmalidir!" xətası çıxmalıdır.
         Birdə nömrənin rəqəmlərdən ibarət olub-olmaması yoxlanmalıdır.
         Deyilsə: "Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!" xətası çıxacaq.
         Bu validation'lara əlavə olaraq vəsiqənin nömrəsi get olan zaman ancaq ilk 3 rəqəm user'ə göstəriləcək. Digər rəqəmlər ulduz
         simvolu olaraq çıxacaq. Orda elə etmək lazımdır ki, 3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik
         4 simvol görsənsin və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və 2 simvol ulduz
         olaraq çıxsın.

         Solution of Task in Lesson 1:
         */
        private string _documentSerial;

        public string DocumentSerial {
            get
            {
                return _documentSerial;
            }
            set
            {
                if(value.Length == 2)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsLetter(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                    else
                        this._documentSerial = value;
                }
                else
                {
                    Console.WriteLine("Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!");
                }
            }
        }



        private string _documentNumber;
        public string DocumentNumber
        {
            get
            {
                var length = _documentNumber.Length;
                var showFirstNLetter = 3;
                var hiddenString = "";

                for (int i = 0; i < (length - showFirstNLetter); i++)
                {
                    hiddenString += "*";
                }

                return _documentNumber.Substring(0, showFirstNLetter) + hiddenString;
            }
            set
            {
                if(value.Length == 8)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsNumber(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.WriteLine("Vesiqenin nomresi sadece reqmlerden ibaret olmalidir!");
                    else
                        this._documentSerial = value;
                }
                else
                {
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 herf olmalidir!");
                }
            }
        }
    }
}

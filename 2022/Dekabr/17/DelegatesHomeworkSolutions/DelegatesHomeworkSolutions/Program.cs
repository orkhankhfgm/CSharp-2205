﻿using DelegatesHomeworkSolutions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesHomeworkSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             Yuxarıda 1 delegate'iniz var və 3 dənə də standart adi method. Elə etməlisiniz ki, məsələn myDelegate adında bir dəyişəniniz olsun və myDelegate dəyişənini
             method kimi istifadə edə biləsiniz. Yəni myDelegate() yazanda bir method işləmiş olsun. Bu qayda da sadəcə 1 dəyişən sayəsində Add, Edit, Delete methodlarını işlətməlisiz.
             Bunu etmək üçün biraz araşdırmalı olacaqsız.
             */
            RunAnyMethod delegateMethod = new RunAnyMethod(Add);
            delegateMethod();

            delegateMethod = new RunAnyMethod(Edit);
            delegateMethod();

            delegateMethod = new RunAnyMethod(Delete);
            delegateMethod();


            /*
             Homework 2:
             Bir Car class'ınız olsun. (Property'ləri: Şəhər (satıldığı), Marka, Model, Buraxılış ili, Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı,
             Sürətlər Qutusunun tipi, Qiyməti)

             Nümunə data:
             Şəhər: Bakı
             Marka: Lexus
             Model: GX460
             Buraxılış ili: 2021
             Rəngi: Black (Enum olacaq və 10-15 dənə rəng olsun Enum'da)
             Mühərrik Həcmi: 4500
             At Gücü: 296
             Kilometrajı: 15777
             Sürətlər Qutusunun tipi: Automatic (Enum olacaq dəyərləri də Automatic, Manual, Robot)
             Qiyməti: 200.000

             Aşağıdakı sorğuları yazın:
             1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
             2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan (2020 də daxildir buna)
             3. Kilometrajı 0 olan və Modelində "ML" sözü olan
             4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
             5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
             6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.
             */

            List<Car> cars = new List<Car>()

            var q1 = cars.Where(m => m.Brand == "Mercedes" && m.Engine <= 4200 && m.City == "Baku");

            var q2 = cars.Where(m => m.City != "Baku" && (m.Year >= 2015 && m.Year <= 2020));

            var q3 = cars.FindAll(m => m.Km == 0 && m.Model.ToLower().Contains("ml"));

            var q4 = cars.FirstOrDefault(m => m.GearBoxType == GearBoxTypeEnum.Automatic && (m.Price > 15000 && m.Price < 17500));

            var q5 = cars.FirstOrDefault(m =>
                    (m.Color != ColorEnum.Red || m.Color != ColorEnum.Black) &&
                    (m.Engine > 2000 && m.Engine < 4000) &&
                    (m.GearBoxType != GearBoxTypeEnum.Robot) &&
                    (m.Year >= 2010));

            var q6 = cars.FindAll(m =>
                    (m.Brand == "Lexus" && m.Price <= 30000) ||
                    (m.Brand == "Mercedes" && m.Price <= 45000));
        }

        public delegate void RunAnyMethod();

        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Add method");
        }

        public static void Delete()
        {
            Console.WriteLine("Add method");
        }
    }
}
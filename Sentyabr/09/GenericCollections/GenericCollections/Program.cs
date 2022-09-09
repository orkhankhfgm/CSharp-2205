using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualDatabase virtualDb = new VirtualDatabase();

            virtualDb.Add(10);
            virtualDb.Add(20);

            #region Using simple Generic Colections
            //Not Generic Collectioin
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");

            //<T> : T tipi, .NET framework'unun içində olan və ya bizim yaratdığımız hər hansısa bir tip deməkdir.
            List<int> genericList = new List<int>();
            genericList.Add(5);
            genericList.Add(15);
            genericList.Add(20);

            List<string> names = new List<string>();
            names.Add("Orkhan");
            names.Add("Musa");
            names.Add("Ceyhun");
            #endregion

            #region Using custom types with Generic Collection and Linq methods
            List<Student> students = new List<Student>();

            //1-ci yol
            students.Add(new Student {
                Id = 1,
                Name = "Cavid",
                Surname = "Heyderov",
                Age = 15
            });

            //2-ci yol
            Student student = new Student()
            {
                Id = 2,
                Name = "Hesen",
                Surname = "Hesenov",
                Age = 25
            };
            students.Add(student);

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                    students[i].Id,
                    students[i].Name,
                    students[i].Surname,
                    students[i].Age
                    );
            }

            foreach (var item in students)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                    item.Id,
                    item.Name,
                    item.Surname,
                    item.Age
                    );
            }
            #endregion


            List<int> numbers = new List<int>();
            numbers.Add(1);

            int[] numbersToAdd = new int[10];

            numbersToAdd[0] = 10;
            numbersToAdd[1] = 20;
            numbersToAdd[2] = 30;
            numbersToAdd[3] = 40;
            numbersToAdd[4] = 50;
            numbersToAdd[5] = 60;
            numbersToAdd[6] = 70;
            numbersToAdd[7] = 80;
            numbersToAdd[8] = 90;
            numbersToAdd[9] = 100;

            //1-ci yol
            for (int i = 0; i < numbersToAdd.Length; i++)
            {
                numbers.Add(numbersToAdd[i]);
            }

            //2-ci yol
            numbers.AddRange(numbersToAdd);




            List<double> doubleList = new List<double>();
            doubleList.Add(10.1);
            doubleList.Add(20.1);
            doubleList.Add(30.1);
            doubleList.Add(40.1);

            //Capacity ilkin olaraq 4 olacaq ve 5-ci element elave olunan zaman 8 olacaq
            var capacityOfDoubleList = doubleList.Capacity;

            //Count ise her zaman element sayina beraber olur
            var countOfDoubleList = doubleList.Count;

            //5-ci elementi elave edirem
            doubleList.Add(50.1);

            //Burda capacity 8 olacaq
            var secondCapacityOfDoubleList = doubleList.Capacity;
            var secondCountOfDoubleList = doubleList.Count;

            doubleList.TrimExcess();
            Console.Clear();

            doubleList.ForEach(i => Console.WriteLine(i));
        }
    }
}

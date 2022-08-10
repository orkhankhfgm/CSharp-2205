using PartialClass_And_Enum.Enums;
using System;

namespace PartialClass_And_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Id = 1;
            book.CreateDate = DateTime.Now;
            book.CreateUser = 100;
            book.Code = 123456789;
            book.Genre = "SomeGenre";
            book.Publisher = "SomePublisher";
            book.Cover = "Karton";
            book.Author = "SomeAuthor";
            book.Page = 356;
            book.Language = "ENG";
            book.Add(book);
            book.Update(book);
            book.Delete(1);




            //Partial class Car example
            Car car = new Car();
            car.Id = 5;
            car.CreateDate = DateTime.Now;
            car.CreateUser = 100;
            car.Brand = "Mercedes";
            car.Model = "GL500";
            car.Year = 2021;
            car.SeatCount = 6;
            car.SeatMaterial = "Deri";
            car.Door = 5;
            car.Engine = 5000;
            car.FuelType = "Benzin";
            car.Add(car);
            car.Update(car);
            car.Delete(5);



            Person person = new Person();
            person.Name = "Orkhan";
            person.Surname = "Farajov";
            person.Gender = GenderEnum.Male;

            person.GenderInteger = (int)GenderEnum.Male;

            if(person.Gender == GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person isn't Male");

            if (person.Gender.Equals(GenderEnum.Male))
                Console.WriteLine("Gender is equal to Male");
            else
                Console.WriteLine("Gender isn't equal to Male");

            if(person.GenderInteger == (int)GenderEnum.Male)
                Console.WriteLine("Gender is Male");
            else
                Console.WriteLine("Gender isn't Male");
        }
    }
}

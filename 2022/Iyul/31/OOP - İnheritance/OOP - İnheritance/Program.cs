using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //car.ToString() //Object'den gelir
            //car.Color //Car.cs'den gelir

            Student student = new Student();
            student.Id = 1000;
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Age = 27;
            student.ClassName = "11A";
            student.Degree = "Some Degree";
            student.RegDate = DateTime.Now;
            student.EditDate = DateTime.Now;

            Teacher teacher = new Teacher();
            teacher.Id = 1000;
            teacher.Name = "Orkhan";
            teacher.Surname = "Farajov";
            teacher.Age = 27;
            teacher.Branch = "Some Branch";
            teacher.IsProfessor = true;
            teacher.RegDate = DateTime.Now;

            Employee employee = new Employee();
            employee.Id = 1000;
            employee.Name = "Orkhan";
            employee.Surname = "Farajov";
            employee.Age = 27;
            employee.JobTitle = "Software Developer";
            employee.Salary = 100;
            employee.RegDate = DateTime.Now;



            #region Task in Lesson 1
            /*
             Car:
                Id,
                Brand,
                Model,
                Km,
                Engine,
                Price,
                CreateDate,
                EditDate
             Phone:
                Id,
                Brand,
                Model,
                FastCharge,
                MadeInCountry,
                Price,
                CreateDate,
                EditDate,
              Teacher: 
                Id,
                Name,
                Surname,
                BirthDate,
                Gender,
                CreateDate,
                EditDate
             */
            #endregion
        }
    }
}

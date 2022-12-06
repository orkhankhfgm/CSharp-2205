using Linq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ = Language Integrated Query

            /*
             Customer classiniz olsun Id, Name, Age
             DataSource adinda ayri bir class'iniz olsun icinde de Customer tipinde bir list olacaq
             Datasource class'inin constructor'unda FakeData ile Customers listinde 100.000 dene melumat elave edin
             Daha sonra bu DataSource classinda 2 method'unuz olsun. Birinci method parametr olaraq herf alacaq ve o herfle adi baslayan
             musterileri list olaraq qaytaracaq.
             Ikinci method ise, bir yas araligi alsin. O yas araliginda olan adamlari return etsin. Meselen 15-25
             */

            DataSource ds = new DataSource();

            //Without Linq
            var age18_25 = ds.GetCustomersByAge(18, 25);
            var namesStartWithB = ds.GetCustomersByFirstLetterOfName('B');

            //With Linq
            var ageFilter = ds.GetCustomersByAgeLinq(18, 25);
            var nameFilter = ds.GetCustomersByFirstLetterOfNameLinq('B');


            #region Linq queries
            /*
             ---- System.Linq ----
             1. ds.Customers.Where()
             2. ds.Customers.FirstOrDefault()
             3. ds.Customers.Max()

             ---- System.Collections.Generic ----
             1. ds.Customers.Add()
             2. ds.Customers.AddRange()
             3. ds.Customers.GetEnumerator()
             */
            var maleCustomers = ds.Customers.Where(m => m.Gender == Gender.Male);

            //Musteri sayisini almaq
            var countOfCustomers = ds.Customers.Count;

            //Olkesi almaniya olmayanlari goturmek
            var notFromGermany = ds.Customers.Where(m => m.Country != "Germany");

            //Olkesi turkiye olanlari goturmek
            var fromTurkey = ds.Customers.Where(m => m.Country == "Turkey");

            //Olkesi almaniya olmayan ve yasi 20-den boyuk olanlari goturmek
            var notFromGermanyAndOver20 = ds.Customers.Where(m => m.Country != "Germany" && m.Age > 20);

            //Adi t herfi ile baslayib, soyadi n ile biten
            var startsT_endsN = ds.Customers.Where(m =>
                m.Name.ToLower().StartsWith("t") &&
                m.Surname.ToLower().EndsWith("n"));

            var notFromGermanyArr = notFromGermany.ToArray();
            var fromTurkeyList = fromTurkey.ToList();

            //IEnumerable System.Collections.Generic'den gelir
            IEnumerable<Customer> badQuery = ds.Customers.Where(p => p.Name.StartsWith("N"));
            badQuery = badQuery.Take<Customer>(1);

            //IQueryable System.Linq'den gelir
            IQueryable<Customer> goodQuery = ds.Customers.AsQueryable().Where(p => p.Name.StartsWith("N"));
            goodQuery = goodQuery.Take<Customer>(1);

            //bad:  select * from Customers where Name like 'N%'
            //good: select top 1 * from Customers where Name like 'N%'

            var methodSyntax = ds.Customers.Where(a =>
                                a.Name.StartsWith("A") &&
                                a.Age >= 45 &&
                                a.Age <= 55)
                                .Count();

            var querySyntax = (from a in ds.Customers
                               where
                                a.Name.StartsWith("A") &&
                                a.Age >= 45 &&
                                a.Age <= 55
                               select a)
                               .Count();

            var customers1 = ds.Customers.Where(c =>
                                c.Name.ToLower().Contains("c") &&
                                c.IsActive);
            #endregion


            #region Practise Linq
            //1. Olkesinin adinda b herfi olan ve seherinin adi c ile baslayan
            IEnumerable<Customer> query1 = ds.Customers.Where(m => m.Country.ToLower().Contains("b") && m.City.ToLower().StartsWith("c"));

            //2. Seherinin adi a herfi ile baslayan ve e ile biten
            IEnumerable<Customer> query2 = ds.Customers.Where(m => m.City.ToLower().StartsWith("a") && m.City.ToLower().EndsWith("e"));

            //3. Adi Jack olanlar
            List<Customer> query3 = ds.Customers
                .Where(m => m.Name == "Jack")
                .ToList();

            //4. Telefon nomresi 0555555555 olan bir nefer
            Customer query4 = ds.Customers.FirstOrDefault(m => m.Phone == "0555555555");

            //5. Dogum tarixi 1990-ci il olanlar
            var query5 = ds.Customers.Where(m => m.DateOfBirth.Year == 1990).ToList();

            //6. Doguldugu ay dekabr olanlardan 2 neferi al
            var query6 = ds.Customers.Where(m => m.DateOfBirth.Month == 12).ToList();
            #endregion


            #region Func Delegate
            //1. Simple Lambda Expression to get Customers whose email address starts with A
            var q1 = ds.Customers.Where(m => m.Email.ToLower().StartsWith("a"));

            //2. Standart Delegate with method
            bool StartsWith(Customer m)
            {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            }
            Func<Customer, bool> startsWithA_delegate = new Func<Customer, bool>(StartsWith);

            var q2 = ds.Customers.Where(startsWithA_delegate);

            //3. Pass method directly to Where with Func<>
            var q3 = ds.Customers.Where(new Func<Customer, bool>(StartsWith));

            //4. Write without Func<>
            var q4 = ds.Customers.Where(delegate (Customer m)
            {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            });

            //5. Write without delegate
            var q5 = ds.Customers.Where((Customer m) => { return m.Email[0] == 'A' ? true : false; });

            //6. Write without object type
            var q6 = ds.Customers.Where((m) => { return m.Email[0] == 'A' ? true : false; });

            //7. Again lambda expression (shortest way)
            var q7 = ds.Customers.Where(m => m.Email[0] == 'A');
            #endregion


            #region Predicate Delegate
            //1. Normal FindAll method
            var p1 = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));

            //2. Long version
            bool predicateDelegateMethod(Customer m)
            {
                if (m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12))
                    return true;
                else
                    return false;
            }

            Predicate<Customer> predicate = new Predicate<Customer>(predicateDelegateMethod);

            var delegate1 = ds.Customers.FindAll(predicate);

            //3. Short versions
            var delegate2 = ds.Customers.FindAll(new Predicate<Customer>(predicateDelegateMethod));

            var delegate3 = ds.Customers.FindAll(delegate (Customer m) { return m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12); });

            var delegate4 = ds.Customers.FindAll((Customer m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));

            var delegate5 = ds.Customers.FindAll((m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));

            var delegateLambda = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));
            #endregion


            #region Action Delegate
            //1. Normal foreach
            foreach (var item in ds.Customers)
            {
                Console.WriteLine($"{item.Name} {item.Surname} is {item.Age} years old.");
            }

            //2. With Foreach method which is in Collections Generic namespace
            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            //3. Long versions
            void ShowCustomerInfo(Customer m)
            {
                Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old.");
            }

            Action<Customer> action = new Action<Customer>(ShowCustomerInfo);
            ds.Customers.ForEach(action);

            //4. Short versions
            ds.Customers.ForEach(new Action<Customer>(ShowCustomerInfo));

            ds.Customers.ForEach(delegate (Customer m) { Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."); });

            ds.Customers.ForEach((Customer m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            //5. Shortest versions
            ds.Customers.ForEach((m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));
            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));
            #endregion
        }
    }
}

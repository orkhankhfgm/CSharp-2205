using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOfFileAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> Humans = new List<Human>();
            List<CountryStatistic> CountryStatistics = new List<CountryStatistic>();

            string choose;
            do
            {
                Console.WriteLine("Emeliyyati seçin: ");
                Console.WriteLine("1. 1000 nəfər yarat");
                Console.WriteLine("2. İnsanları göstər");
                Console.WriteLine("3. Çıxış");

                choose = Console.ReadLine();

                if (choose == "1")
                {
                    Random rand = new Random();

                    if (!Directory.Exists("C:/Countries/"))
                        Directory.CreateDirectory("C:/Countries/");

                    for (int i = 0; i < 100000; i++)
                    {
                        Human human = new Human(FakeData.NameData.GetFirstName(), FakeData.NameData.GetSurname(), FakeData.NetworkData.GetDomain(), FakeData.PlaceData.GetCountry());
                        Humans.Add(human);

                        if (!Directory.Exists("C:/Countries/" + human.Country))
                            Directory.CreateDirectory("C:/Countries/" + human.Country);

                        File.Create($"C:/Countries/{human.Country}/{human.Name}-{human.Surname}-{rand.Next(100000, 999999)}.txt");
                    }
                }
                else if (choose == "2")
                {
                    Console.WriteLine("Olkelerin statistikasi: ");

                    string[] subDirs = Directory.GetDirectories("C:/Countries");

                    for (int i = 0; i < subDirs.Length; i++)
                    {
                        DirectoryInfo dir = new DirectoryInfo(subDirs[i]);
                        var population = dir.GetFiles().Length;
                        var countryName = subDirs[i].Substring(subDirs[i].LastIndexOf(@"\")+1);

                        CountryStatistics.Add(new CountryStatistic(countryName, population));

                        Console.WriteLine($"Olke: {countryName} - Ehali: {population}");
                    }

                    Console.WriteLine("Total Population:" + CountryStatistics.Sum(m=>m.Population));
                    Console.WriteLine("Min Population:" + CountryStatistics.Min(m => m.Population));
                    Console.WriteLine("Max Population:" + CountryStatistics.Max(m => m.Population));
                    Console.ReadLine();
                }

                Console.Clear();
            } while (choose != "3");
        }
    }
}

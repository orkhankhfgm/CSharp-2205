using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PastHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework1();
        }

        public static void Homework1()
        {
            XDocument Xdocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                    new XComment("Tələbə məlumatları"),
                    new XElement("Students",
                        new XComment("Tələbə 1"),
                        new XElement("Student",
                            new XAttribute("Id", "1"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 2"),
                        new XElement("Student",
                            new XAttribute("Id", "2"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 3"),
                        new XElement("Student",
                            new XAttribute("Id", "3"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 4"),
                        new XElement("Student",
                            new XAttribute("Id", "4"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 5"),
                        new XElement("Student",
                            new XAttribute("Id", "5"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 6"),
                        new XElement("Student",
                            new XAttribute("Id", "6"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 7"),
                        new XElement("Student",
                            new XAttribute("Id", "7"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 8"),
                        new XElement("Student",
                            new XAttribute("Id", "8"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 9"),
                        new XElement("Student",
                            new XAttribute("Id", "9"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 10"),
                        new XElement("Student",
                            new XAttribute("Id", "10"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        )
                    )
            );
            Xdocument.Save(@"C:\\XML\\Students.xml");
        }
    }
}

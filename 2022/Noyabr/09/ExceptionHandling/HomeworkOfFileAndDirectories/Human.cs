namespace HomeworkOfFileAndDirectories
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public Human(string name, string surname, string domain, string country)
        {
            Name = name;
            Surname = surname;
            Email = name + "." + surname + domain;
            Country = country;
        }
    }
}

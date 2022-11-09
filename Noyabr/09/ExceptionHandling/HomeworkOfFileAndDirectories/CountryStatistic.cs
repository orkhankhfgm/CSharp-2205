namespace HomeworkOfFileAndDirectories
{
    public class CountryStatistic
    {
        public string Country { get; set; }
        public int Population { get; set; }

        public CountryStatistic(string country, int population)
        {
            Country = country;
            Population = population;
        }
    }
}

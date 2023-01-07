namespace PartialClass_And_Enum
{
    public partial class Car : BaseClass<Car>
    {
        public string Brand { get; set; } //Marka
        public string Model { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; } //Oturacaq sayi
        public string SeatMaterial { get; set; } //Oturacaq deri/parca
        public int Door { get; set; } //Qapi sayi
        public int Engine { get; set; } //Motoru: (Meselen: 2000)
        public string FuelType { get; set; }

        public override Car Get(int id)
        {
            return new Car();
        }

        public override Car[] GetAll()
        {
            return new Car[10];
        }

        public override int Add(Car item)
        {
            return 1;
        }

        public override Car Update(Car item)
        {
            return new Car();
        }

        public override bool Delete(int id)
        {
            return true;
        }
    }
}

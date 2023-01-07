using DelegatesHomeworkSolutions.Enums;

namespace DelegatesHomeworkSolutions
{
    public class Car
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public ColorEnum Color { get; set; }
        public int Engine { get; set; }
        public int HP { get; set; }
        public decimal Km { get; set; }
        public GearBoxTypeEnum GearBoxType { get; set; }
        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes_Homework
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal KmUsed { get; set; }
        public int FuelType { get; set; }
        public int TransmissionType { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal MaxDiscount { get; set; }
        public decimal Price { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string _brand, string _model)
        {
            Brand = _brand;
            Model = _model;
        }

        public Vehicle(string _brand, string _model, int _year)
        {
            Brand = _brand;
            Model = _model;
            Year = _year;
        }

        public Vehicle(string _brand, string _model, int _year, decimal KmUsed)
        {
            Brand = _brand;
            Model = _model;
            Year = _year;
            this.KmUsed = KmUsed;
        }

        public void ShowVehicleInfo()
        {
            Console.WriteLine("Brand: {0} - Model: {1} - Year: {2} - Price: {3}",
                Brand, Model, Year, Price);
        }

        public void SetPrice(decimal _price)
        {
            decimal calcMinPrice = SellPrice - MaxDiscount;

            if(_price < calcMinPrice)
                Console.WriteLine("Price can't update!");
            else
            {
                this.Price = _price;
                Console.WriteLine("Price updated!");
            }
        }
    }
}

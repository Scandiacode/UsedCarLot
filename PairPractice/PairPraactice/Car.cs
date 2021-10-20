using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairPraactice
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0m;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-15}{2,-20}{3,-25}", Make, Model, Year, Price);
        }
    }
}

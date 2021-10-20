using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairPraactice
{
    class UsedCar: Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage):base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public UsedCar():base()
        {
            Mileage = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}  (Used)  {Mileage}";
        }
    }
}

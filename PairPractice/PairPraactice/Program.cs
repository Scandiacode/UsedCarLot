using System;
using System.Collections.Generic;

namespace PairPraactice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>
            {
               new Car("Mitsubishi", "3000GT", 1995, 89000),
               new UsedCar("Jeep", "Wrangler", 2016, 33998, 54000),
            };

            CarLot ALot = new CarLot(CarList);
            ALot.CarMenu();

        }
    }
}

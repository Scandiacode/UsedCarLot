using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairPraactice
{
    class CarLot
    {
        List<Car> CarList = new List<Car>();

        public CarLot(List<Car> CarList)
        {
            this.CarList = CarList;
        }

        public void DisplayCars()
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + CarList[i].ToString());
            }
        }

        public void CarMenu()
        {
            int input;
            do
            {

                try
                {
                    Console.WriteLine("1. Buy a car \n2.Add a car \n3.End program");
                    input = int.Parse(Console.ReadLine());
                    if (input <= 3)
                        if (input >= 1)
                            break;
                    Console.WriteLine("Number must be between 1 and 3");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a number.");
                }
            } while (true);

            if (input == 1)
            {
                do
                {
                    try
                    {

                        DisplayCars();
                        Console.WriteLine("enter car number");
                        input = int.Parse(Console.ReadLine()) - 1;
                        if (input <= CarList.Count)
                            if (input >= 1)
                                break;
                        Console.WriteLine("Number must be between 1 and " + CarList.Count());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Must enter a number.");
                    }

                } while (true);
                Car bought = CarList[input];
                Console.WriteLine("you just bought " + bought.ToString());
                CarList.RemoveAt(input);
            }






        }
    }
}

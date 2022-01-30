using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class CarRepository
    {


        static public Car AddCar()
        {
            bool loop = true;
            string brand, model;
            Console.WriteLine($@"Enter your own brand");
            brand = Console.ReadLine();
            Console.WriteLine($@"Enter your own model");
            model = Console.ReadLine();
            Console.WriteLine($"Enter your own production year:");
            int yearProduction = 0;
            bool myBool;
            while (loop)
            {
                myBool = int.TryParse(Console.ReadLine(), out yearProduction);
                if (myBool && yearProduction > 1952 && yearProduction < 2022)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct details");
                }
            }
            return new Car(brand, model, yearProduction);
        }

    }
}

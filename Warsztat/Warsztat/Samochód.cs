using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Car

    {
        string brand;
        string model;
        int productionYear;
        int power;

        public string BrandCar
        {
            get { return this.brand; }
            set { brand = value; }
        }
        public string ModelCar
        {
            get { return this.model; }
            set { model = value; }
        }
        public int ProductionYear
        {
            get { return this.productionYear; }
            set { productionYear = value; }
        }
        public int Power
        {
            get { return this.power; }
            set { power = value; }
            
        }

        public string AddBrandCar()
        {
            Console.WriteLine($@"Enter your own brand");
            brand = Console.ReadLine();
        }

        public string AddModelCar()
        {
            Console.WriteLine($@"Enter your own model");
            model = Console.ReadLine();
        }

        public int AddProductionYear()
        {
            bool loop = true;
            Console.WriteLine($"Enter your own production year:");
            int yearProduction = 0;
            while (loop)
            {
                yearProduction = int.TryParse(Console.ReadLine(), out yearProduction) ? yearProduction : 0;
                if (yearProduction != 0 && yearProduction > 1952 && yearProduction < 2022)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Enter the correct details");
                }
            }
        }

        public int AddPower()
        {
            bool loop = true;
            Console.WriteLine($"Enter your own power:");
            int power = 0;
            while (loop)
            {
                power = int.TryParse(Console.ReadLine(), out power) ? power : 0;
                if (power != 0 && power > 30 && power < 800)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Enter the correct details");
                }
            }
        }
        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza
    //Klasa stworzona tymczasowo, w razie konflitku podczas merga nadpisać klasą Car Łukasza

    internal class Car
    {
        public string BrandCar;
        public string ModelCar;
        public int ProductionYearCar;
        public Car(string brand, string model, int productionYear)
        {
            BrandCar = brand;
            ModelCar = model;
            ProductionYearCar = productionYear;
        }

        public Car()
        {

        }

        public void AddCar()
        {
            Console.WriteLine("Declare car brand: ");
            BrandCar = Console.ReadLine();
            Console.WriteLine("Declare car model: ");
           ModelCar = Console.ReadLine();
            Console.WriteLine("Declare car production year: ");
            ProductionYearCar = Int32.Parse(Console.ReadLine());

        }
    }
}

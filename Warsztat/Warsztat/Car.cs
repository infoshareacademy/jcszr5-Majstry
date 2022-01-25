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
            // nie wiem o co z tym chodzi ale jak sie chce wywołać funkcje w innej klasie bez podawania jej parametrów to VS podpowiada Create constructor in Klasa

        }

    }
}

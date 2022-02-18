using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Order
    {
        public string Status { get; set; }
        public string Fault { get; set; }
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public int ProductionYearOfCar { get; set; }
      public Mechanic Mechanic { get; set; }

        public Order(string status, string fault, Mechanic mechanic, int productionYearOfCar, string brandOfCar, string modelOfCar)
        {
            Status = status;
            Fault = fault;
            BrandOfCar = brandOfCar;
            ModelOfCar = modelOfCar;
            ProductionYearOfCar = productionYearOfCar;
            Mechanic = mechanic;

        }
    }
}

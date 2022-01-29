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

        public Order(int number, string status, string fault, Mechanic mechanic, Car car)//Add parameter Car car, Person mechanic
        {
            Number = number;
            Status = status;
            Fault = fault;
            Mechanic = mechanic;
            Car = car;
        }

        public int Number { get; set; }
        public string Status { get; set; }
        public string Fault { get; set; }
        public Mechanic Mechanic { get; set; }
        public Car Car { get; set; }

        

        public void CreateNewOrder(Order order)
        { 
            Console.WriteLine("Please declare status: Waiting/ Verification/ In progress/ Ended");
            Status = Console.ReadLine();
            Console.WriteLine("Short describe of problem");
            Fault = Console.ReadLine();

        }

        public void PrintAllOrders(List<Order> orders)//Wyświetlanie zlecenia wprowadzonego z konosli
        {
            Console.WriteLine("Result");
            Console.WriteLine(" ");
            
            foreach (Order order in orders)
            {
                Number = orders.IndexOf(order) + 1;

               // Number = order.ReadFromFile().IndexOf(order)+1;

                Console.WriteLine($"Order number      : 00{order.Number}");
                Console.WriteLine($"Status            : {order.Status}");
                Console.WriteLine($"Fault             : {order.Fault}");
            }
        }
        public void SaveToFile(List<Order> orders)// zapis listy do pliku
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json", json);
        }

        public List<Order> ReadFromFile()// odczyt listy z pliku
        {
            string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json");
            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
            
            return orderFromFile;
        }

        // public void PrintAllOrdersFromFile()// wyświetlenie listy z pliku
        // {
        //     string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json");
        //     List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
        //    
        //     foreach (var order in orderFromFile)
        //     { 
        //         Number = orderFromFile.IndexOf(order) + 1;
        //         Console.WriteLine($"Order number      : {order.Number}");
        //         Console.WriteLine($"Status            : {order.Status}");
        //         Console.WriteLine($"Fault             : {order.Fault}");
        //         Console.WriteLine($"Car brand         : {order.BrandOfCar}");
        //         Console.WriteLine($"Model             : {order.ModelOfCar}");
        //         Console.WriteLine($"Year of production: {order.ProductionYearOfCar}");
        //         Console.WriteLine($"Mechanic :{order.MechanicName} {order.MechanicSurname}");
        //     }
        // }
        public void FindOrder(List<Order> orders)
        {

        }

    }
}
/*[
  {
    "Number": 1,
    "Status": "Waiting",
    "Fault": "No air in wheels",
    "BrandOfCar": "Fiat",
    "ModelOfCar": "126p",
    "ProductionYearOfCar": 1995,
    "MechanicName": "Rysiek",
    "MechanicSurname": "Niepsuj"
  },
  
    {
      "Number": 2,
      "Status": "Ended",
      "Fault": "No fuel",
      "BrandOfCar": "Fiat",
      "ModelOfCar": "Multipla",
      "ProductionYearOfCar": 1999,
      "MechanicName": "Kazimierz",
      "MechanicSurname": "Saleta"
    },
	 {
    "Number": 3,
    "Status": "In progres",
    "Fault": "Oil change",
    "BrandOfCar": "Mercedes",
    "ModelOfCar": "Vito",
    "ProductionYearOfCar": 2005,
    "MechanicName": "Rysiek",
    "MechanicSurname": "Niepsuj"
  }
  
]


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Order
    { // private string status;
        // private string fault;
        // private int number;
        public Order(int number, string status, string fault, string brandOfCar, string modelOfCar, int productionYearOfCar, string mechanicName, string mechanicSurname)//Add parameter Car car, Person mechanic
        {
            Number = number;
            Status = status;
            Fault = fault;
            BrandOfCar = brandOfCar;
            ModelOfCar = modelOfCar;
            ProductionYearOfCar = productionYearOfCar;
            MechanicName = mechanicName;
            MechanicSurname = mechanicSurname;
        }
        public Order()
        {
            // nie wiem o co z tym chodzi ale jak sie chce wywołać funkcje w innej klasie bez podawania jej parametrów to VS podpowiada Create constructor in Klasa
        }
        public int Number { get; set; }
        public string Status { get; set; }
        public string Fault { get; set; }
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public int ProductionYearOfCar { get; set; }
        public string MechanicName { get; set; }
        public string MechanicSurname { get; set; }
        
        public void AddMechanic()

        {
            Worker worker = new Worker();
            Mechanic mechanic = new Mechanic();
            Console.WriteLine("Declare mechanic name:");
            mechanic.FirstName = Console.ReadLine();
            Console.WriteLine("Declare mechanic surname:");
            mechanic.LastName = Console.ReadLine();
            MechanicName = mechanic.FirstName;
            MechanicSurname = mechanic.LastName;
        }

        public void AddCar()
        {
            Car car = new Car();
            Console.WriteLine("Declare car brand: ");
            car.BrandCar = Console.ReadLine();
            Console.WriteLine("Declare car model: ");
            car.ModelCar = Console.ReadLine();
            Console.WriteLine("Declare car production year: ");
            car.ProductionYearCar = Int32.Parse(Console.ReadLine());
            BrandOfCar = car.BrandCar;
            ModelOfCar = car.ModelCar;
            ProductionYearOfCar = car.ProductionYearCar;
        }

        public void CreateNewOrder(Order order)
        { //ReadFromFile();
            order = new Order();
            Car car = new Car();
            Console.WriteLine("Please declare status: Waiting/ Verification/ In progress/ Ended");
            Status = Console.ReadLine();
            Console.WriteLine("Short describe of problem");
            Fault = Console.ReadLine();
            AddCar();
            AddMechanic();
           
        }

        public void PrintAllOrders(List<Order> orders)//Wyświetlanie zlecenia wprowadzonego z konosli
        {
            Console.WriteLine("Result");
            Console.WriteLine(" ");

            foreach (Order order in orders)
            {
                Number = orders.IndexOf(order) + 1;

                Console.WriteLine($"Order number      : {order.Number}");
                Console.WriteLine($"Status            : {order.Status}");
                Console.WriteLine($"Fault             : {order.Fault}");
                Console.WriteLine($"Car brand         : {order.BrandOfCar}");
                Console.WriteLine($"Model             : {order.ModelOfCar}");
                Console.WriteLine($"Year of production: {order.ProductionYearOfCar}");
                Console.WriteLine($"Mechanic :{order.MechanicName} {order.MechanicSurname}");
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
            orderFromFile = new List<Order>();
            return orderFromFile;
        }

        public void PrintAllOrdersFromFile()// wyświetlenie listy z pliku
        {
            //ReadFromFile(); //Pownienem tu wykorzystać tę metode   zamiast kopiowania jej zawartość ale nie wiem czemu wtedy mi sie nic nie wyświetla

            string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json");
            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
            foreach (var order in orderFromFile)
            {
                Console.WriteLine($"Order number      : {order.Number}");
                Console.WriteLine($"Status            : {order.Status}");
                Console.WriteLine($"Fault             : {order.Fault}");
                Console.WriteLine($"Car brand         : {order.BrandOfCar}");
                Console.WriteLine($"Model             : {order.ModelOfCar}");
                Console.WriteLine($"Year of production: {order.ProductionYearOfCar}");
                Console.WriteLine($"Mechanic :{order.MechanicName} {order.MechanicSurname}");
            }
        }
        public void OrderSort(List<Order> orders)
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
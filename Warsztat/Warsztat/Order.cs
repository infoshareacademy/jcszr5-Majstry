using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Order
    {
        // private string status;
        // private string fault;
        // private int number;
       
        public Order(int number, string status, string fault, string brandOfCar, string modelOfCar, int productionYearOfCar, string mechanicName, string mechanicSurname)//Add parameter Car car, Person mechanic
        {
            this.Number = number;
            this.Status = status;
            this.Fault = fault;
            this.BrandOfCar = brandOfCar;
            this.ModelOfCar = modelOfCar;
            this.ProductionYearOfCar = productionYearOfCar;
            this.MechanicName = mechanicName;
            this.MechanicSurname = mechanicSurname;
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
        {
            Car car = new Car();
            List<Order> orders = new List<Order>();
            Console.WriteLine("Please declare status: Waiting/ Verification/ In progress/ Ended");
            Status = Console.ReadLine();
            Console.WriteLine("Short describe of problem");
            Fault = Console.ReadLine();
            AddCar();// Dogadać z Łukaszem czy stworzy metode AddCar, czy odwołać sie do klasy Car - Car car = new Car() (tak jak jest teraz)
            AddMechanic();
            // BrandOfCar = car.BrandCar;
            // ModelOfCar = car.ModelCar;
            // ProductionYearOfCar = car.ProductionYearCar;
        }
        public void PrintAllOrders(List<Order> orders)
        {

            Console.WriteLine("Result");
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
        public void OrderSort(List<Order> orders)
        {

        }

    }
}

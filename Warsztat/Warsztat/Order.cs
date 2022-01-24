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
       
        public Order(int number, string status, string fault, string brandOfCar, string modelOfCar, int productionYearOfCar)//Add parameter Car car, Person mechanic
        {
            this.Number = number;
            this.Status = status;
            this.Fault = fault;
            this.BrandOfCar = brandOfCar;
            this.ModelOfCar = modelOfCar;
            this.ProductionYearOfCar = productionYearOfCar;


        }
        public Order()
        {

        }
        public int Number { get; set; }
        public string Status { get; set; }
        public string Fault { get; set; }
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public int ProductionYearOfCar { get; set; }



        public void CreateNewOrder(Order order)
        {
            Car car = new Car();
            List<Order> orders = new List<Order>();
            Console.WriteLine("Please declare status: Waiting/ Verification/ In progress/ Ended");
            Status = Console.ReadLine();
            Console.WriteLine("Short describe of problem");
            Fault = Console.ReadLine();
            car.AddCar();
            BrandOfCar = car.BrandCar;
            ModelOfCar = car.ModelCar;
            ProductionYearOfCar = car.ProductionYearCar;
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

            }
        }
        public void OrderSort(List<Order> orders)
        {

        }

    }
}

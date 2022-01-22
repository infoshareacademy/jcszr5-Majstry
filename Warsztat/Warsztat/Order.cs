using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Order
    {
        public Order(string status, string fault, int number, int position)//Add parameter Car car, Person mechanic
        {
            this.Status = status;
            this.Fault = fault;
            this.Number = number;
            this.Position = position;
        }
        public Order()
        {

        }
        public string Status { get; set; }
        public string Fault { get; set; }
        public int Number { get; set; }
        public int Position { get; set; }

        public void CreateNewOrder(Order order)
        {
            List<Order> orders = new List<Order>();
            Console.WriteLine("Please declare status: Waiting/ Verification/ In progress/ Ended");
            Status = Console.ReadLine();
            Console.WriteLine("Short describe of problem");
            Fault = Console.ReadLine();

            Console.WriteLine("Please declare number of repair station");
            Position = Int32.Parse(Console.ReadLine());
            orders.Add(order);
        }
        public void PrintAllOrders(List<Order> orders)
        {
            Console.WriteLine("Result");
            foreach (Order order in orders)
            {
                Number = orders.IndexOf(order) + 1;

                Console.WriteLine($"Order number: {order.Number}");
                Console.WriteLine($"Status: {order.Status}");
                Console.WriteLine($"Fault: {order.Fault}");
                Console.WriteLine($"Repair station: {order.Position}");
            }
        }
        public void OrderSort(List<Order> orders)
        {

        }

    }
}

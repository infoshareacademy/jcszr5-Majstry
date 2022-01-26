using System;
using System.Text.Json;
using static Warsztat.Order;

namespace Warsztat
{

    class Program
    {
        static void Main(string[] args)
        {
            // List<Order> orders = new List<Order>();
            Order order = new Order();
            order.PrintAllOrdersFromFile();
            //order.ReadFromFile();
            List<Order> orders = order.ReadFromFile();
            order.CreateNewOrder(order);
            orders.Add(order);
            order.SaveToFile(orders);
            order.PrintAllOrdersFromFile();
            // order.ReadFromFile();
            //  order.PrintAllOrders(orders);

        }

    }
}

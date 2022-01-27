using System;
using System.Text.Json;
using static Warsztat.Order;

namespace Warsztat
{

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            List<Order> orders = order.ReadFromFile();
            order.CreateNewOrder(order);
            orders.Add(order);
            order.SaveToFile(orders);
            order.ReadFromFile();
            order.PrintAllOrders(orders);
        }

    }
}

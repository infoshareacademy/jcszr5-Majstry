using System;
using static Warsztat.Order;

namespace Warsztat
{

    class Program
    {
       static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            Order order = new Order();
            order.CreateNewOrder(order);
            orders.Add(order);
            order.PrintAllOrders(orders);
        }

    }
}

using System;
using System.Runtime.CompilerServices;
using Warsztat;



namespace ClassOrder
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            Order order = new Order();
            order.CreateNewOrder(order);
            orders.Add(order);
            order.PrintAllOrders(orders);
        }

    }
}
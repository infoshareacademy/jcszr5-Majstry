using System;
using System.Text.Json;
using static Warsztat.Order;

// klasy:
// Krzysztof => pracownik => mechanik, księgowa;
// Łukasz => samochód,
// Krystian => część, narzędzia,
// Artur => zlecenie


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
=======

        }

    }
}

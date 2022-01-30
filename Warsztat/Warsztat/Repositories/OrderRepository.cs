using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class OrderRepository
    {
        List<Order> Orders = new List<Order> {};
        public void CreateNewOrder()
        {
            Console.WriteLine("Create order. Insert order informations below:");
            Console.WriteLine("Status (Waiting / In progress / Finished");
            string status = Console.ReadLine();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
            Console.WriteLine("Choose mechanic:");
            Mechanic mechanic = new Mechanic(status, fault, 55, 50000);
            Car car = CarRepository.AddCar();
            Orders.Add(new Order( status, fault, mechanic, car));

            // na razie zrobiłem na odpierdziel, trzeba uzupełnić wybór mechanika,
            // samochód z funkcji, a mechanik, żeby wybrać z dodanych mechaników.

        }

        public void PrintAllOrders(List<Order> orders)//Wyświetlanie zlecenia wprowadzonego z konosli
        {
            Console.WriteLine("Result");
            Console.WriteLine(" ");

            foreach (Order order in orders)
            {
                //Console.WriteLine($"Order number      : 00{order.Number}");
                Console.WriteLine($"Status            : {order.Status}");
                Console.WriteLine($"Fault             : {order.Fault}");
            }
        }
        //public void SaveToFile(List<Order> orders)// zapis listy do pliku
        //{
            // tu był jakiś błąd, nie miałem siły tego szukać
            //string json = JsonSerializer.Serialize(orders);
        //    File.WriteAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json", json);
        //}

       // public List<Order> ReadFromFile()// odczyt listy z pliku
        //{
        //    string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json");
           // List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
           // tu też
            //return orderFromFile;
       // }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Warsztat
{
    public class OrderRepository
    {
        List<Order> orders = new List<Order> ();
        public void CreateNewOrder()
        {

           List <Order> orders = ReadFromFile();

            Console.WriteLine("Create order. Insert order informations below:");
            Console.WriteLine("Status (Waiting / In progress / Finished");
            string status = Console.ReadLine();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
      
            Console.WriteLine("Choose mechanic:");
            Mechanic mechanic = new Mechanic(status, fault, 55, 50000);
       
             Car car = CarRepository.AddCar();
            // Car car = new Car()
           // Car car = new Car;
           // CarRepository carRepository = new CarRepository();
            

            orders.Add(new Order(status, fault, mechanic, car));// dodałem
            SaveToFile(orders);// dodałem
        }

        public void PrintAllOrders(List<Order> orders)
        {
            
            Console.WriteLine(" ");

            foreach (Order order in orders)
            {
                //Console.WriteLine($"Order number      : 00{order.Number}");
                Console.WriteLine($"Status            : {order.Status}");
                Console.WriteLine($"Fault             : {order.Fault}");
            }
        }
        public void SaveToFile(List<Order> orders)// zapis listy do pliku
        {
            
            // string json = JsonSerializer.Serialize(orders);
            // File.WriteAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json", json);
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(@".\OrderList.json", json);
        }

        public List<Order> ReadFromFile()// odczyt listy z pliku
        {
            // string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\path.json");
            //List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
            string jsonFromFile = File.ReadAllText(@".\OrderList.json");
            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);

            return orderFromFile;   
        }
    }
}



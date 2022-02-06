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
            Car car = CarRepository.AddCar();



            Console.WriteLine("Choose mechanic:");
            EmployeeRepo employeeReposiotry = new EmployeeRepo();
            List<Mechanic> mechanics = employeeReposiotry.ReadMechanicFromFile();
            employeeReposiotry.ReadMechanicFromFile();
            Mechanic mechanic = employeeReposiotry.ChooseMechanic();
            orders.Add(new Order(status, fault, mechanic, car.ProductionYear, car.Brand, car.Model));
            SaveToFile(orders);
        }

        public void PrintAllOrders(List<Order> orders)
        {

            orders = ReadFromFile();

            Console.WriteLine(" ");
            foreach (Order order in orders)
            {
                int indexOfOrder = orders.IndexOf(order);
                Console.WriteLine(indexOfOrder + 1);
                Console.WriteLine($"Status              : {order.Status}");
                Console.WriteLine($"Fault               : {order.Fault}");
                Console.WriteLine($"Car brand           : {order.BrandOfCar}");
                Console.WriteLine($"Model               : {order.ModelOfCar}");
                Console.WriteLine($"Year of production  : {order.ProductionYearOfCar}");
                Console.WriteLine($"Mechanic            :{order.Mechanic.FirstName} {order.Mechanic.LastName}");
                Console.WriteLine("");
            }
    
        }

        public void SaveToFile(List<Order> orders)// zapis listy do pliku
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(@".\OrderList.json", json);
        }

        public List<Order> ReadFromFile()// odczyt listy z pliku
        {
            string jsonFromFile = File.ReadAllText(@".\OrderList.json");
            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);

            return orderFromFile;   
        }
    }
}



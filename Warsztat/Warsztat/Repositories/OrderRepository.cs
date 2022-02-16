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



            Console.WriteLine("Choose mechanic by declaring number:");
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
                DecorateLine();
                Console.WriteLine(indexOfOrder + 1);
                Console.WriteLine($"Status              : {order.Status}");
                Console.WriteLine($"Fault               : {order.Fault}");
                Console.WriteLine($"Car brand           : {order.BrandOfCar}");
                Console.WriteLine($"Model               : {order.ModelOfCar}");
                Console.WriteLine($"Year of production  : {order.ProductionYearOfCar}");
                Console.WriteLine($"Mechanic            :{order.Mechanic.FirstName} {order.Mechanic.LastName}");
                DecorateLine();
            }
    
        }

        public void SaveToFile(List<Order> orders)
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(@".\OrderList.json", json);
        }

        public List<Order> ReadFromFile()
        {
            string jsonFromFile = File.ReadAllText(@".\OrderList.json");
            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);

            return orderFromFile;   
        }

        public void RemoveSelectedOrder()
        {

            PrintAllOrders(orders);
            DecorateLine();
            Console.WriteLine($"Declare number of order for delete");
            DecorateLine();
            orders = ReadFromFile();

            int indexForRemove = int.Parse(Console.ReadLine());
            orders.RemoveAt(indexForRemove - 1);
            SaveToFile(orders);

        }
        public void SortingOrdersByStatus()
        {
            orders = ReadFromFile();

            Console.WriteLine("Enter the status number by which you want to sort");
            Console.WriteLine("1.Waiting");
            Console.WriteLine("2.In progress");
            Console.WriteLine("3.Finished");
           
            DecorateLine();

            int numberOfStatus = int.Parse(Console.ReadLine());
            DecorateLine(); ;

            if (numberOfStatus == 1)
            {
                foreach (Order order in orders)
                {
                    if (order.Status == "Waiting")
                    {
                        int indexOfOrder = orders.IndexOf(order);
                        DecorateLine();
                        Console.WriteLine(indexOfOrder + 1);
                        Console.WriteLine($"Status              : {order.Status}");
                        Console.WriteLine($"Fault               : {order.Fault}");
                        Console.WriteLine($"Car brand           : {order.BrandOfCar}");
                        Console.WriteLine($"Model               : {order.ModelOfCar}");
                        Console.WriteLine($"Year of production  : {order.ProductionYearOfCar}");
                        Console.WriteLine($"Mechanic            :{order.Mechanic.FirstName} {order.Mechanic.LastName}");
                        DecorateLine();
                    }
                }
            }
            if (numberOfStatus == 2)
            {
                foreach (Order order in orders)
                {
                    if (order.Status == "In progress")
                    {
                        int indexOfOrder = orders.IndexOf(order);
                        DecorateLine();
                        Console.WriteLine(indexOfOrder + 1);
                        Console.WriteLine($"Status              : {order.Status}");
                        Console.WriteLine($"Fault               : {order.Fault}");
                        Console.WriteLine($"Car brand           : {order.BrandOfCar}");
                        Console.WriteLine($"Model               : {order.ModelOfCar}");
                        Console.WriteLine($"Year of production  : {order.ProductionYearOfCar}");
                        Console.WriteLine($"Mechanic            :{order.Mechanic.FirstName} {order.Mechanic.LastName}");
                        DecorateLine();
                    }
                }
            }
            if (numberOfStatus == 3)
            {
                foreach (Order order in orders)
                {
                    if (order.Status == "Finished")
                    {
                        int indexOfOrder = orders.IndexOf(order);
                        DecorateLine();
                        Console.WriteLine(indexOfOrder + 1);
                        Console.WriteLine($"Status              : {order.Status}");
                        Console.WriteLine($"Fault               : {order.Fault}");
                        Console.WriteLine($"Car brand           : {order.BrandOfCar}");
                        Console.WriteLine($"Model               : {order.ModelOfCar}");
                        Console.WriteLine($"Year of production  : {order.ProductionYearOfCar}");
                        Console.WriteLine($"Mechanic            :{order.Mechanic.FirstName} {order.Mechanic.LastName}");
                        DecorateLine();
                    }
                }
            }
            DecorateLine();
            Console.WriteLine("Press eny key to continue");
            Console.ReadLine();
        }
        public void EditDeclaredOrder()
        {
            PrintAllOrders(orders);
            DecorateLine();
            Console.WriteLine($"Declare number of order to change");
            DecorateLine();
            orders = ReadFromFile();
            int indexToEdit = int.Parse(Console.ReadLine()) - 1;
            DecorateLine();
            Console.WriteLine("Status (Waiting / In progress / Finished)");
            string status = Console.ReadLine();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
            Car car = CarRepository.AddCar();
            Console.WriteLine("Choose mechanic:");
            EmployeeRepo employeeReposiotry = new EmployeeRepo();
            List<Mechanic> mechanics = employeeReposiotry.ReadMechanicFromFile();
            employeeReposiotry.ReadMechanicFromFile();
            Mechanic mechanic = employeeReposiotry.ChooseMechanic();
            orders[indexToEdit] = new Order(status, fault, mechanic, car.ProductionYear, car.Brand, car.Model);
            SaveToFile(orders);
        }

        public void DecorateLine()
        {
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}



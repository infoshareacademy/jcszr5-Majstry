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
        List<Order> orders = new List<Order>();
        EmployeeRepository employeeReposiotry = new EmployeeRepository();
        int indexOfOrder;

        public void CreateNewOrder()
        {
            List<Order> orders = ReadFromFile();
            Console.WriteLine("Create order. Insert order informations below:");
            DecorateLine();
            string status = SelectStatus();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
            DecorateLine();
            Car car = CarRepository.AddCar();
            Console.WriteLine("Choose mechanic by declaring number:");
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
                indexOfOrder = orders.IndexOf(order);
                PrintSingleOrder(order, indexOfOrder);

            }

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
            DecorateLine();
            if (numberOfStatus == 1)
            {
                foreach (Order order in orders)
                {
                    if (order.Status == "Waiting")
                    {
                        indexOfOrder = orders.IndexOf(order);
                        PrintSingleOrder(order, indexOfOrder);
                    }
                }
            }
            if (numberOfStatus == 2)
            {
                foreach (Order order in orders)
                {
                    if (order.Status == "In progress")
                    {
                        indexOfOrder = orders.IndexOf(order);
                        PrintSingleOrder(order, indexOfOrder);
                    }
                }
            }
            if (numberOfStatus == 3)
            {
                foreach (Order order in orders)
                {
                    if (order.Status == "Finished")
                    {
                        indexOfOrder = orders.IndexOf(order);
                        PrintSingleOrder(order, indexOfOrder);
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
            orders = ReadFromFile();
            int indexToEdit = int.Parse(Console.ReadLine()) - 1;
            DecorateLine();
            string status = SelectStatus();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
            DecorateLine();
            Car car = CarRepository.AddCar();
            DecorateLine();
            Console.WriteLine("Choose mechanic:");
            List<Mechanic> mechanics = employeeReposiotry.ReadMechanicFromFile();
            employeeReposiotry.ReadMechanicFromFile();
            Mechanic mechanic = employeeReposiotry.ChooseMechanic();
            orders[indexToEdit] = new Order(status, fault, mechanic, car.ProductionYear, car.Brand, car.Model);
            SaveToFile(orders);
        }
        public void SaveToFile(List<Order> orders)
        {
            string json = JsonSerializer.Serialize(orders);
            File.WriteAllText(@"D:\InfoShaREaCADEMY\Projekt\Wersja robocza warsztat\jcszr5-Majstry\Warsztat\Warsztat\OrderList.json", json);
        }
        public List<Order> ReadFromFile()
        {
            string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Wersja robocza warsztat\jcszr5-Majstry\Warsztat\Warsztat\OrderList.json");
            List<Order> orderFromFile = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
            return orderFromFile;
        }

        string SelectStatus()
        {
            Console.WriteLine("Status number:");
            Console.WriteLine("1.Waiting");
            Console.WriteLine("2.In progress");
            Console.WriteLine("3.Finished");
            DecorateLine();
            string status = "Undeclared";

            int numberOfStatus;
            string strNumberOfStatus = Console.ReadLine();
            DecorateLine();

            bool inputIsInteger = int.TryParse(strNumberOfStatus, out numberOfStatus);
            while (inputIsInteger == false || numberOfStatus < 1 || numberOfStatus > 3)
            {
                Console.WriteLine("Wrong data input. Select numbers 1-3.");
                strNumberOfStatus = Console.ReadLine();
                DecorateLine();
                inputIsInteger = int.TryParse(strNumberOfStatus, out numberOfStatus);
            }

            if (numberOfStatus == 1)
            {
                status = "Waiting";
            }
            if (numberOfStatus == 2)
            {
                status = "In progress";
            }
            if (numberOfStatus == 3)
            {
                status = "Finished";
            }
            return status;
        }
        public void DecorateLine()
        {
            Console.WriteLine("-----------------------------------------------------------------");
        }
        void PrintSingleOrder(Order order, int indexOfOrder)
        {
            DecorateLine();
            Console.WriteLine(indexOfOrder + 1);
            Console.WriteLine($"Status              : {order.Status}");
            Console.WriteLine($"Fault               : {order.Fault}");
            Console.WriteLine($"Car brand           : {order.BrandOfCar}");
            Console.WriteLine($"Model               : {order.ModelOfCar}");
            Console.WriteLine($"Year of production  : {order.ProductionYearOfCar}");
            Console.WriteLine($"Mechanic            : {order.Mechanic.FirstName} {order.Mechanic.LastName}");
            DecorateLine();
        }
    }
}



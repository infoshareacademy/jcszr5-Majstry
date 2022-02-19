namespace Warsztat
{
    public class OrderService
    {
        OrderRepository orderRepository = new OrderRepository();
        EmployeeService employeeService = new EmployeeService();


        public void CreateNewOrder()
        {

            List<Order> orders = orderRepository.ReadFromFile();

            Console.WriteLine("Create order. Insert order informations below:");
            Console.WriteLine("Status (Waiting / In progress / Finished");
            DecorateLine();
            string status = SelectStatus();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
            DecorateLine();
            Car car = CarService.AddCar();
            Console.WriteLine("Choose mechanic by declaring number:");
            Mechanic mechanic = employeeService.ChooseMechanic();
            orders.Add(new Order(status, fault, mechanic, car.ProductionYear, car.Brand, car.Model));
            orderRepository.SaveToFile(orders);
        }

        public void PrintAllOrders()
        {
            var orders = orderRepository.ReadFromFile();

            Console.WriteLine(" ");
            foreach (Order order in orders)
            {
                int indexOfOrder = orders.IndexOf(order);
                PrintSingleOrder(order, indexOfOrder);
            }

        }

        public void RemoveSelectedOrder()
        {

            PrintAllOrders();
            DecorateLine();
            Console.WriteLine($"Declare number of order for delete");
            DecorateLine();
            var orders = orderRepository.ReadFromFile();

            int indexForRemove = int.Parse(Console.ReadLine());
            orders.RemoveAt(indexForRemove - 1);
            orderRepository.SaveToFile(orders);

        }
        public void SortingOrdersByStatus()
        {
            var orders = orderRepository.ReadFromFile();

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
                        int indexOfOrder = orders.IndexOf(order);
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
                        int indexOfOrder = orders.IndexOf(order);
                        PrintSingleOrder(order, indexOfOrder);
                    }
                }
            }
            DecorateLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
        public void EditDeclaredOrder()
        {
            PrintAllOrders();
            DecorateLine();
            Console.WriteLine($"Declare number of order to change");
            DecorateLine();
            var orders = orderRepository.ReadFromFile();
            int indexToEdit = int.Parse(Console.ReadLine()) - 1;
            DecorateLine();
            string status = SelectStatus();
            Console.WriteLine("Short description of a problem:");
            string fault = Console.ReadLine();
            Car car = CarService.AddCar();
            Console.WriteLine("Choose mechanic:");
            Mechanic mechanic = employeeService.ChooseMechanic();
            orders[indexToEdit] = new Order(status, fault, mechanic, car.ProductionYear, car.Brand, car.Model);
            orderRepository.SaveToFile(orders);
        }

        public void DecorateLine()
        {
            Console.WriteLine("-----------------------------------------------------------------");
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

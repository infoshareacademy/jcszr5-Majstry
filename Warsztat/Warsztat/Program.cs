namespace Warsztat
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Option> startMenuOptions = new List<Option>
           {
                new Option("Orders"),
                new Option("Employees"),
                new Option("Parts"),
                new Option("Exit") //() => Environment.Exit(0))
            };

            List<Option> orderMenuOptions = new List<Option>
            {
                new Option("Add an order"),
                new Option("Delete an order"),
                new Option("Edit an order"),
                new Option("Show filtered orders by status"),
                new Option("Show all orders"),
                new Option("Main menu"),
            };

            List<Option> employeeMenuOptions = new List<Option>
            {
                new Option("Add an employee"),
                new Option("Delete an employee"),
                new Option("Edit an employee"),
                new Option("Show all employees"),
                new Option("Main menu"),
            };

            List<Option> partsMenuOptions = new List<Option>
            {
                new Option("Add part"),
                new Option("Show parts"),
                new Option("Edit quantity of a part"),
                new Option("Parts quantity review"),
                new Option("Main menu"),
            };

            OrderRepository orderRepository = new OrderRepository();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Parts parts = new Parts();

            bool program = true;
            int index = 0;
            int menuOption = 0;
            var currentMenuOptions = startMenuOptions; 
            ConsoleKeyInfo keyinfo;

            do
            {
                Menu.Menu.WriteMenu(currentMenuOptions, currentMenuOptions[index]);
                keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < currentMenuOptions.Count)
                    {
                        index++;
                        Menu.Menu.WriteMenu(currentMenuOptions, currentMenuOptions[index]);
                    }
                }

                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        Menu.Menu.WriteMenu(currentMenuOptions, currentMenuOptions[index]);
                    }
                }

                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    if (menuOption == 0)
                    {
                        switch (index)
                        {
                            case 0:
                                currentMenuOptions = orderMenuOptions;
                                menuOption = 1;
                                index = 0;
                                continue;

                            case 1:
                                currentMenuOptions = employeeMenuOptions;
                                menuOption = 2;
                                index = 0;
                                continue;

                            case 2:
                                currentMenuOptions = partsMenuOptions;
                                menuOption = 3;
                                index = 0;
                                continue;

                            case 3:
                                Environment.Exit(0);
                                break;
                        }
                    }

                    if (menuOption == 1)
                    {
                        switch (index)
                        {
                            case 0:
                                Console.Clear();
                                orderRepository.CreateNewOrder();
                                break;

                            case 1:
                                Console.Clear();
                                orderRepository.RemoveSelectedOrder();
                                break;

                            case 2:
                                Console.Clear();
                                orderRepository.EditDeclaredOrder();
                                break;

                            case 3:
                                Console.Clear();
                                orderRepository.SortingOrdersByStatus();
                                break;

                            case 4:
                                Console.Clear();
                                List<Order> orders = orderRepository.ReadFromFile();
                                orderRepository.PrintAllOrders();
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                break;

                            case 5:
                                currentMenuOptions = startMenuOptions;
                                menuOption = 0;
                                index = 0;
                                continue;
    
                        }
                    }
                    if (menuOption == 2)
                    {
                        switch (index)
                        {
                            case 0:
                                Console.Clear();
                                employeeRepository.AddMechanic();
                                break;
                            case 1:
                                Console.Clear();
                                employeeRepository.RemoveSelectedMechanic();
                                break;
                            case 2:
                                Console.Clear();
                                employeeRepository.EditDeclaredMechanic();
                                break;

                            case 3:
                                Console.Clear();
                                employeeRepository.PrintAllMechanics();
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                break;

                            case 4:
                                currentMenuOptions = startMenuOptions;
                                menuOption = 0;
                                index = 0;
                                continue;
                        }
                    }

                    if (menuOption == 3)
                    {
                        switch (index)
                        {
                            case 0:
                                Console.Clear();
                                parts.AddPart();
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                break;

                            case 1:
                                Console.Clear();
                                parts.PrintAllPart();
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.Clear();
                                parts.AddPart();
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                break;

                            case 3:
                                break;

                            case 4:
                                currentMenuOptions = startMenuOptions;
                                menuOption = 0;
                                index = 0;
                                continue;
                        }
                    }
                    index = 0;
                }
            }
            while (program);
        }
    }
}

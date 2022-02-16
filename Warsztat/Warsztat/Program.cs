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

        public static List<Option> startMenuOptions;

        static void Main(string[] args)
        {
          
            startMenuOptions = new List<Option>
           {
                new Option("Add an order"),
                new Option("Delete an order"),
                new Option("Edit an order"),
                new Option("Status of an order"),
                new Option("Show all orders"),

                new Option("Add an employee"),
                new Option("Delete an employee"),
                new Option("Edit an employee"),
                new Option("Status of an employee"),
                new Option("Show all employee"),

                new Option("Add part"),
                new Option("Delete part"),
                new Option("Edit part"),
                new Option("Parts quantity review"),
                new Option("Exit") //() => Environment.Exit(0))
            };
            bool program = true;
            int index = 0;
            ConsoleKeyInfo keyinfo;
            OrderRepository orderRepository = new OrderRepository();
            EmployeeRepo employeeRepo = new EmployeeRepo();
            do
            {
                Menu.Menu.WriteMenu(startMenuOptions, startMenuOptions[index]);
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < startMenuOptions.Count)
                    {
                        index++;
                        Menu.Menu.WriteMenu(startMenuOptions, startMenuOptions[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        Menu.Menu.WriteMenu(startMenuOptions, startMenuOptions[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    switch (index)
                    {
                        case 0:                    
                            orderRepository.CreateNewOrder();
                            break;
                        case 1:                      
                            orderRepository.RemoveSelectedOrder();
                            break;
                        case 2:                       
                            orderRepository.EditDeclaredOrder();
                            break;
                        case 3:                        
                            orderRepository.SortingOrdersByStatus();
                            break;
                        case 4:                     
                            List<Order> orders = orderRepository.ReadFromFile();
                            orderRepository.PrintAllOrders(orders);
                            Console.WriteLine("Press eny key to continue");
                            Console.ReadLine();
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                      
                            break;
                        case 10:
                            break;
                        case 11:
                            break;
                        case 12:
                            break;
                        case 13:
                            break;
                        case 14:
                            Environment.Exit(0);
                            break;                            
                             
                    }
                    index = 0;
                }
            }
            while (program);
            Console.ReadKey();
        }
    }
}

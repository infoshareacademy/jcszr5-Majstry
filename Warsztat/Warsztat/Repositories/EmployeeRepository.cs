using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Warsztat
{
    public class EmployeeRepository
    {
        public List<Employee> Employees = new List<Employee> ();
        public List<Mechanic> Mechanics = new List<Mechanic>();



        public virtual List<Employee> AddEmployees()
        {
            LoadFromFile();
            Console.WriteLine("Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Surname:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age");
            bool loop = true;
            int age = 0, money = 0, myInt;
            while (loop)
            {
                bool myBool = int.TryParse(Console.ReadLine(), out myInt);
                if (myBool && myInt > 15 && myInt < 128)
                {
                    age = myInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct data");
                }
            }
            Console.WriteLine("Salary:");
            while (loop)
            {
                bool myBool = int.TryParse(Console.ReadLine(), out myInt);
                if (myBool && myInt > -1)
                {
                    money = myInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct data");
                }
            }
            Mechanic employee = new Mechanic(firstName, lastName, age, money);
            Mechanics.Add(employee);
            Employees.Add(employee);
  
            return Employees;
        }
        
        public void SaveToFile()
        {
            SaveMechanicToFile(Mechanics);
            //string json = JsonSerializer.Serialize(Employees);
            //File.WriteAllText(@"C:\Users\2021\source\repos\jcszr5-Majstry\Warsztat\Warsztat\employeList.json", json);
        }
        public List<Employee> LoadFromFile()
        {
            Mechanics = ReadMechanicFromFile();
            Employees = new List<Employee>();
            foreach (Employee employee in Mechanics)
            {
                Employees.Add((Employee)employee);
            }
            return Employees;
            
        }
        public void PresentAllEmployee(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                int index = employees.IndexOf(employee);
                Console.WriteLine(index);
                employee.ShowEmployee(employee);
                //Thread.Sleep(2000);
            }
        }
        public void DeleteMechanic()
        {
            
            bool loop = true;
            int number = 0, myInt = 0;
            PresentAllEmployee(LoadFromFile());
            
            while (loop)
            {
                bool myBool = int.TryParse(Console.ReadLine(), out myInt);
                if (myBool && myInt < Mechanics.Count)
                {
                    Mechanics.RemoveAt(myInt);
                    SaveMechanicToFile(Mechanics);
                    //PresentAllEmployee(LoadFromFile());
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct data");
                }
            }
        }
        public void DeleteEmploye()
        {
            DeleteMechanic();
        }
        public void EditMechanic()
        {
            Console.WriteLine("Select employee to edit:");
            
            DeleteMechanic();
            Console.WriteLine("Adding new data:");
            AddEmployees();
            SaveMechanicToFile(Mechanics);
        }
        public void EditEmploye()
        {
            EditMechanic();
        }

        public void MechanicsStatus()
        {
            //OrderRepository orderRepo = new OrderRepository();
            
            //ReadMechanicFromFile();
            //var employesBusy = Mechanics.Except(list2).ToList();
        }

        public Mechanic ChooseMechanic()// PRZYPISANIE MECHANIKA DO ZLECENIA
        {
            List<Mechanic> mechanics = ReadMechanicFromFile();
            ReadMechanicFromFile();
            PrintAllMechanics(mechanics);
            Mechanic mechanic = mechanics[int.Parse(Console.ReadLine()) - 1];
            return mechanic;
        }

        public void PrintAllMechanics(List<Mechanic> mechanics)// WYŚWIETLANIE LISTY MECHANIKÓW
        {

            foreach (Mechanic mechanic in mechanics)
            {
                int index = mechanics.IndexOf(mechanic) + 1;
                Console.WriteLine($"{index}.{mechanic.FirstName} {mechanic.LastName}");
            }
        }

        public void EditDeclaredMechanic()
        {
            PrintAllMechanics();
            DecorateLine();
            Console.WriteLine($"Declare number of order to change");
            DecorateLine();
            var mechanics = ReadMechanicFromFile().ToList();
            int indexToEdit = int.Parse(Console.ReadLine()) - 1;
            DecorateLine();
            Console.WriteLine("Enter data about ");
            Console.WriteLine("Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Surname:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age");
            bool loop = true;
            int age = 0, money = 0, myInt;
            while (loop)
            {
                bool myBool = int.TryParse(Console.ReadLine(), out myInt);
                if (myBool && myInt > 15 && myInt < 128)
                {
                    age = myInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct data");
                }
            }
            while (loop)
            {
                bool myBool = int.TryParse(Console.ReadLine(), out myInt);
                if (myBool && myInt > -1)
                {
                    money = myInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct data");
                }
            }
            mechanics[indexToEdit] = new Mechanic(firstName, lastName, age, money);
            SaveMechanicToFile(mechanics);
        }

        public void SaveMechanicToFile(List<Mechanic> mechanics)// zapis listy do pliku
        {
            string json = JsonSerializer.Serialize(mechanics);
            File.WriteAllText(@"C:\Users\2021\source\repos\jcszr5-Majstry\Warsztat\Warsztat\employeList.json", json);
            
        }


        public List<Mechanic> ReadMechanicFromFile()// odczyt listy z pliku
        {
            string jsonFromFile = File.ReadAllText(@"C:\Users\2021\source\repos\jcszr5-Majstry\Warsztat\Warsztat\employeList.json");
            List<Mechanic> mechanicFromFile = JsonSerializer.Deserialize<List<Mechanic>>(jsonFromFile);

            return mechanicFromFile;
        }








    }

}

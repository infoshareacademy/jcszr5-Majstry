using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Warsztat
{
    public class EmployeeRepo
    {
        List<Employee> Employees = new List<Employee> { };
      
        public void AddMechanic()
        {
            
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

            Employees.Add(new Mechanic(firstName, lastName, age, money));       
        }

        public Mechanic ChooseMechanic()
        {
            List<Mechanic> mechanics = ReadMechanicFromFile();
            ReadMechanicFromFile();
            PrintAllMechanicsForOrder();
            Mechanic mechanic = mechanics[int.Parse(Console.ReadLine()) - 1];
            return mechanic;
        }

        public void PrintAllMechanicsForOrder()
        {
           
            List<Mechanic> mechanics = ReadMechanicFromFile();
            foreach (Mechanic mechanic in mechanics)
            {
                int index = mechanics.IndexOf(mechanic) + 1;
                Console.WriteLine($"{index}.{mechanic.FirstName} {mechanic.LastName}");
            }
        }

        public void SaveMechanicToFile(List<Mechanic> mechanics)
        {
            string json = JsonSerializer.Serialize(mechanics);
            File.WriteAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\MechanicList.json", json);
        }
   
        public List<Mechanic> ReadMechanicFromFile()
        {
            string jsonFromFile = File.ReadAllText(@"D:\InfoShaREaCADEMY\Projekt\Projekt Warsztat\jcszr5-Majstry\Warsztat\Warsztat\MechanicList.json");
            List<Mechanic> mechanicFromFile = JsonSerializer.Deserialize<List<Mechanic>>(jsonFromFile);

            return mechanicFromFile;
        }
    }
    
}

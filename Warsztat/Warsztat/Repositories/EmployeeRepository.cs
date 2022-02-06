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
      
        public void AddMechanic()//było void zmieniłem na Mechanic
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














        //Dodałem metode na potrzeby wyboru mechanika podczas tworzenia zlecenia

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
            Console.WriteLine("Choose Mechanic by declaring number:");
            foreach (Mechanic mechanic in mechanics)
            {
                int index = mechanics.IndexOf(mechanic) + 1;
                Console.WriteLine($"{index}.{mechanic.FirstName} {mechanic.LastName}");
            }
        }

        public void SaveMechanicToFile(List<Mechanic> mechanics)// zapis listy do pliku
        {
            string json = JsonSerializer.Serialize(mechanics);
            File.WriteAllText(@".\MechanicList.json", json);
        }

        public List<Mechanic> ReadMechanicFromFile()// odczyt listy z pliku
        {
            string jsonFromFile = File.ReadAllText(@".\MechanicList.json");
            List<Mechanic> mechanicFromFile = JsonSerializer.Deserialize<List<Mechanic>>(jsonFromFile);

            return mechanicFromFile;
        }
    }
    
}

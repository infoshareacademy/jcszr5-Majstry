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








        //Ta metoda jest potrzebna tylko mi, do przypisania mechanika do zlecenia wiec jej nie zmieniajmy.
        public Mechanic ChooseMechanic()// PRZYPISANIE MECHANIKA DO ZLECENIA
        {
            List<Mechanic> mechanics = ReadMechanicFromFile();
            ReadMechanicFromFile();
            PrintAllMechanicsForOrder(/*mechanics*/);
            Mechanic mechanic = mechanics[int.Parse(Console.ReadLine()) - 1];
            return mechanic;
        }

        /*W tej metodzie zmieńmy nazwe na PrintAllMechanicsForOrder i nic poza tym, bo już ją wykorzystuje. Pewnie bedziesz tworzył kolejną metode wyświetlającą mechaników tylko że z wiekszą ilością properities
        i ją prawdopodobnie bedziesz chciał nazwać PrintAllMechanics*/
        public void PrintAllMechanicsForOrder()// WYŚWIETLANIE LISTY MECHANIKÓW
        {
           
            List<Mechanic> mechanics = ReadMechanicFromFile();
            foreach (Mechanic mechanic in mechanics)
            {
                int index = mechanics.IndexOf(mechanic) + 1;
                Console.WriteLine($"{index}.{mechanic.FirstName} {mechanic.LastName}");
            }
        }

        //Ta metoda tylko zapisuje do pliku wiec raczej nic tu nie trzeba zmieniać oprócz ścieżki( Michał mówił że trzeba pliki umieścić tak żeby były widoczne w solucji)
        public void SaveMechanicToFile(List<Mechanic> mechanics)
        {
            string json = JsonSerializer.Serialize(mechanics);
            File.WriteAllText(@".\MechanicList.json", json);
        }
        //Ta metoda tylko odczytuje z pliku wiec raczej nic tu nie trzeba zmieniać oprócz ścieżki( Michał mówił że trzeba pliki umieścić tak żeby były widoczne w solucji)
        public List<Mechanic> ReadMechanicFromFile()// odczyt listy z pliku
        {
            string jsonFromFile = File.ReadAllText(@".\MechanicList.json");
            List<Mechanic> mechanicFromFile = JsonSerializer.Deserialize<List<Mechanic>>(jsonFromFile);

            return mechanicFromFile;
        }
    }
    
}

using System.Text.Json;

namespace Warsztat
{
    public class EmployeeRepository
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
            var mechanics = ReadMechanicFromFile();
            mechanics.Add(new Mechanic(firstName, lastName, age, money));
            SaveMechanicToFile(mechanics);
        }

        public void RemoveSelectedMechanic()
        {

            PrintAllMechanics();
            DecorateLine();
            Console.WriteLine($"Declare number of order for delete");
            DecorateLine();
            var mechanics = ReadMechanicFromFile();

            int indexForRemove = int.Parse(Console.ReadLine());
            mechanics.RemoveAt(indexForRemove - 1);
            SaveMechanicToFile(mechanics);
        }

        

        public Mechanic ChooseMechanic()
        {
            List<Mechanic> mechanics = ReadMechanicFromFile();
            ReadMechanicFromFile();
            PrintAllMechanics();
            Mechanic mechanic = mechanics[int.Parse(Console.ReadLine()) - 1];
            return mechanic;
        }

        public void PrintAllMechanics()
        {
           
            List<Mechanic> mechanics = ReadMechanicFromFile();
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

        public void SaveMechanicToFile(List<Mechanic> mechanics)
        {
            string json = JsonSerializer.Serialize(mechanics);
            File.WriteAllText(@".\MechanicList.json", json);
        }

        public List<Mechanic> ReadMechanicFromFile()
        {
            string jsonFromFile = File.ReadAllText(@".\MechanicList.json");
            List<Mechanic> mechanicFromFile = JsonSerializer.Deserialize<List<Mechanic>>(jsonFromFile);

            return mechanicFromFile;
        }

        public void DecorateLine()
        {
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
    
}

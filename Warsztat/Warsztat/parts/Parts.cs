using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Warsztat
{
    public class Parts
    {
        List<Part> addParts = new List<Part>();
        public static List<Option> startMenuOptions;

        public Parts()
        {
            addParts = ReadPartFromFile();
        }

        //public Part AddPartOf()// PRZYPISANIE CZESCI
        //{
        //    List<Parts> AddParts = ReadPartFromFile();
        //    ReadPartFromFile();
        //    PrintAllPart(AddParts);
        //    Parts addPart = addParts[int.Parse(Console.ReadLine()) - 1];
        //    return addPart;
        //}
        public Part SelectPart()
        {
            startMenuOptions = new List<Option>
           {
                new Option("Brake pads"),
                new Option("Oil Engine"),
                new Option("Filter Air"),
                new Option("Filter Petrol"),
                new Option("Brake Discs"),      
            };
            bool program = true;
            int index = 0;
            ConsoleKeyInfo keyinfo;
            Part part = new Part();

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
                            part = addParts[0];
                            break;
                        case 1:
                            part = addParts[1];
                            break;
                        case 2:
                            part = addParts[2];
                            break;
                        case 3:
                            part = addParts[3];
                            break;
                        case 4:
                            part = addParts[4];
                            break;                   
                        case 5:
                            Environment.Exit(0);
                            break;

                    }
                    index = 0;
                }
            }
            while (program);
            Console.ReadKey();

            return part;

        }
        public void PrintAllPart()// WYŚWIETLANIE LISTY CZESCI
        {

            foreach (Part addPart in addParts)
            {       
                Console.WriteLine($"{addPart.PartName} {addPart.PartPrice}");
            }
        }

        public void SavePartToFile(List<Part> addParts) // zapis listy do pliku
        {
            string json = JsonSerializer.Serialize(addParts);
            File.WriteAllText(@".\PartList.json", json);
        }

        public List<Part> ReadPartFromFile()// odczyt listy z pliku
        {
            string jsonFromFile = File.ReadAllText(@".\PartList.json");
            List<Part> PartFromFile = JsonSerializer.Deserialize<List<Part>>(jsonFromFile);

            return PartFromFile;
        }

        public void AddPart()
        { 
            Console.WriteLine("Part Name:");
            string partName = Console.ReadLine();
            Console.WriteLine("Part PRice");
            string partPrice = Console.ReadLine();

            var part = new Part      
            {
                PartName = partName,
                PartPrice = partPrice
            };

            addParts.Add(part);
            SavePartToFile(addParts);
            PrintAllPart();
        }
    
    }
}

using System.Text.Json;

namespace Warsztat
{
    public class Parts
    {
        List<Part> addParts = new List<Part>();

        //public Part AddPartOf()// PRZYPISANIE CZESCI
        //{
        //    List<Parts> AddParts = ReadPartFromFile();
        //    ReadPartFromFile();
        //    PrintAllPart(AddParts);
        //    Parts addPart = addParts[int.Parse(Console.ReadLine()) - 1];
        //    return addPart;
        //}
        
        public void PrintAllPart()// WYŚWIETLANIE LISTY CZESCI
        {
            var parts = ReadPartFromFile();
            foreach (Part part in parts)
            {       
                Console.WriteLine($"Name: {part.PartName} \n Price: {part.PartPrice}");
            }
        }

        public void SavePartToFile(List<Part> parts) // zapis listy do pliku
        {
            string json = JsonSerializer.Serialize(parts);
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
            Console.WriteLine("Part Price");
            string partPrice = Console.ReadLine();

            var part = new Part      
            {
                PartName = partName,
                PartPrice = partPrice
            };
            var partList = ReadPartFromFile();
            partList.Add(part);
            SavePartToFile(partList);
            PrintAllPart();
        }
    
    }
}

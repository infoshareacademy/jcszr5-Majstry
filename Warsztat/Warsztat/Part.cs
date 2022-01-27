using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warsztat;
using System.Text.Json;

namespace Warsztat
{
    public class Part
    {
  

        Part c1 = new Part("Oil engin");
        Part c2 = new Part("Oil gearbox");
        Part c3 = new Part("Air filter");
        Part c4 = new Part("Oil filter");
        Part c5 = new Part("Brake discs");
        Part c6 = new Part("Brake pads");
        Part c7 = new Part("Cabin filter");

        List<Part> parts = new List<Part>();

            parts.Add(p1);
            parts.Add(p2);
            parts.Add(p3);
            parts.Add(p4);
            parts.Add(p5);
            parts.Add(p6);
            parts.Add(p7);


        string json = JsonSerializer.Serialize(parts);

        File.WriteAllText(@"ścieżka do pliku\path123.json", json);

        Console.ReadLine();


        string jsonFromFile = File.ReadAllText(@"ścieżka do pliku\path.json");


        List<Part> partsFromFile = JsonSerializer.Deserialize<List<Part>>(jsonFromFile);
        private string v;

        public Part(string v)
        {
            this.v = v;
        }

        Console.WriteLine(partsFromFile[0].Name);
        Console.WriteLine(cFromFile[1].Name);


        Console.ReadLine();


    }

}


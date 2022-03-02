using System.Text.Json;
using Warsztat_v2.Models;

namespace Warsztat_v2.Services
{
    public class CarrService
    {
        private static List<Carr> Carrs = new List<Carr>
        {
            new Carr()
            {
                Id = 1,
                CarMark = "Audi",
                CarModel = "A6",
                YearProduction1 = 2017,

            },
             new Carr()
            {
                Id = 2,
                CarMark = "Renault",
                CarModel = "Laguna",
                YearProduction1 = 2008,

            },
              new Carr()
            {
                Id = 3,
                CarMark = "Peugeot",
                CarModel = "407",
                YearProduction1 = 2004,

            },
               new Carr()
            {
                Id = 4,
                CarMark = "Toyota",
                CarModel = "Corolla",
                YearProduction1 = 2014,

            },
            new Carr()
            {
                Id = 5,
                CarMark = "Jeep",
                CarModel = "Wrangler",
                YearProduction1 = 2012,

            },
            new Carr()
            {
                Id = 6,
                CarMark = "Citroen",
                CarModel = "C5",
                YearProduction1 = 2020,

            },
             new Carr()
            {
                Id = 7,
                CarMark = "BMW",
                CarModel = "E60",
                YearProduction1 = 2006,

            }
        };

        public void Update(Carr model)
        {
            var carr = GetById(model.Id);
            carr.CarModel = model.CarModel;
            carr.CarMark = model.CarMark;
            carr.YearProduction1 = model.YearProduction1;
            SaveToFile();

        }

        private static int IdCounter = 7;
        public List<Carr> GetAll()
        {
            string jasonFromFile = File.ReadAllText(@"C:\Users\Łukasz\Desktop\RepoWarsztat567\jcszr5-Majstry\Warsztat\Warsztat_v2\CarrList.json");
            Carrs = JsonSerializer.Deserialize<List<Carr>>(jasonFromFile);
            return Carrs;
        }


        public void Delete(int id)
        {
            Carrs.Remove(GetById(id));
            SaveToFile();
        }

        public Carr GetById(int id)
        {
            return Carrs.FirstOrDefault(e => e.Id == id);
        }
        public void Create(Carr carr)
        {
            carr.Id = GetNextId();
            Carrs.Add(carr);
            SaveToFile();
        }
        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(Carrs);

            File.WriteAllText(@"C:\Users\Łukasz\Desktop\RepoWarsztat567\jcszr5-Majstry\Warsztat\Warsztat_v2\CarrList.json", json);
        }

        private int GetNextId()
        {
            IdCounter = IdCounter + 1;
            return IdCounter;
        }

    }
}

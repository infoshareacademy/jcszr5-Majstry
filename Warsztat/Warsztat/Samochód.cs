using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Car

    {
        public Car();
        
        {
                    public string BrandCar { get; set; }
                    public string ModelCar { get; set; }
                    public int ProductionYearCar { get; set; }

                    public int EnginePower { get; set; }


                    string brand;
                    string model;
                    int productionYear;
                    int power;

                    public string BrandCar
                    {
                        get { return this.brand; }
                        set { brand = Console.ReadLine(); }
                    }
                    public string ModelCar
                    {
                        get { return this.model; }
                        set { model = Console.ReadLine(); }
                    }
                    public int ProductionYearCar
                    {
                        get { return this.productionYear; }
                        set 
                        {
                                bool petla = true;
                                int productionYear = 0;
                                while (petla)
                                {
                                    Console.WriteLine("Dziekuje podaj rok produkcji samochodu");
                                     productionYear = int.TryParse(Console.ReadLine(), out productionYear) ? productionYear : 0; //operator warunkowy
                                    if (productionYear != 0 && productionYear > 1950 && productionYear < 2022)
                                    {
                                        petla = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Podaj poprawne dane!");
                                    }

                                }

                         }
                    }
                    public int EnginePower
                    {
                         get { return this.power; }
                         set
                         {
                            bool petla = true;
                            double moc = 0;
                            while (petla)
                            {
                                Console.WriteLine("Dziekuję teraz wprowadź moc samochodu");
                                power = double.TryParse(Console.ReadLine(), out power) ? power : 0;
                                if (power != 0 && power > 30 && power < 600)
                                {
                                    petla = false;
                                }
                                else
                                {
                                    Console.WriteLine("Podaj poprawne dane!");
                                }
                            }
                          } 
                     }
    
    
    }






    }
    
}

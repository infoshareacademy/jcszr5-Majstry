using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Samochod

    {
        public Samochod()
        {

            bool petla = true;
            bool czyWprowadzacNoweAuto = true;

            while (czyWprowadzacNoweAuto)
            {

                Console.WriteLine("Witaj użytkowniku podaj dane samochodu do naprawy");

                Console.WriteLine("Wprowadź marke samochodu");
                string marka;
                marka = Console.ReadLine();


                Console.WriteLine("Podaj model samochodu");
                string model;
                model = Console.ReadLine();

                Console.WriteLine("Podaj vin samochodu");
                string vin;
                model = Console.ReadLine();


                petla = true;
                int rokProdukcji = 0;
                while (petla)
                {
                    Console.WriteLine("Podaj rok produkcji samochodu");
                    rokProdukcji = int.TryParse(Console.ReadLine(), out rokProdukcji) ? rokProdukcji : 0;
                    if (rokProdukcji != 0 && rokProdukcji > 1950 && rokProdukcji < 2022)
                    {
                        petla = false;
                    }
                    else
                    {
                        Console.WriteLine("Podaj poprawne dane!");
                    }

                }

                petla = true;
                double moc = 0;
                while (petla)
                {
                    Console.WriteLine("Wprowadź moc samochodu");
                    moc = double.TryParse(Console.ReadLine(), out moc) ? moc : 0;
                    if (moc != 0 && moc > 30 && moc < 800)
                    {
                        petla = false;
                    }
                    else
                    {
                        Console.WriteLine("Podaj poprawne dane!");
                    }
                }

                petla = true;
                int iloscCzesci = 0;
                while (petla)
                {
                    Console.WriteLine("Podaj ilość części samochodu");
                    iloscCzesci = int.TryParse(Console.ReadLine(), out iloscCzesci) ? iloscCzesci : 0;
                    if (moc != 0 && iloscCzesci > 1 && iloscCzesci < 9)
                    {
                        petla = false;
                    }
                    else
                    {
                        Console.WriteLine("Podaj poprawne dane!");
                    }
                }


                Console.WriteLine("Czy chciałbyś przyjąć kolejny samochód (y)?");
                var czyKolejny = Console.ReadLine();
                if (czyKolejny == "y")
                {
                    czyWprowadzacNoweAuto = true;
                }
                else
                {
                    czyWprowadzacNoweAuto = false;
                }




            }




        }
    }
}

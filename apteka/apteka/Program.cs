using apteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin
{
    internal class Program
    {
        static List<Stoka> magazin = new List<Stoka>();

        static void Main(string[] args)
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- Veterinarna Apteka ---");
                Console.WriteLine("1. Dobavqne na nova stoka");
                Console.WriteLine("2. Pokazvane na vsichki stoki");
                Console.WriteLine("3. Sortirane po ime na hranata (azbuchno)");
                Console.WriteLine("4. Izhod");
                Console.Write("Izberete opciq (1-4): ");
                izbor = Console.ReadLine();

                if (izbor == "1")
                    DobaviStoka();
                else if (izbor == "2")
                    PokajiStoki();
                else if (izbor == "3")
                    SortiranePoIme();
                else if (izbor != "4")
                    Console.WriteLine("Nevaliden izbor!");

            } while (izbor != "4");
        }

        static void DobaviStoka()
        {
            Console.Write("Vuvedete ime na hranata/stokata (do 10 simvola): ");
            string ime = Console.ReadLine();
            if (ime.Length > 10)
            {
                Console.WriteLine("Imeto e tvurde dulgo!");
                return;
            }

            Console.Write("Vid jivotno (kuche / kotka / drugo): ");
            string vid = Console.ReadLine();

            magazin.Add(new Stoka { Ime = ime, VidZivotno = vid });
            Console.WriteLine("Uspeshno dobavena stoka.");
        }

        static void PokajiStoki()
        {
            Console.WriteLine("\n--- Spisuk na vsichki stoki ---");
            if (magazin.Count == 0)
            {
                Console.WriteLine("Nqma vuvedeni stokik.");
            }
            else
            {
                foreach (var stoka in magazin)
                {
                    stoka.Print();
                }
            }
        }

        static void SortiranePoIme()
        {
            Console.WriteLine("\n--- Sortirani stoki po ime ---");
            var sortirani = magazin.OrderBy(s => s.Ime).ToList();
            foreach (var stoka in sortirani)
            {
                stoka.Print();
            }
        }
    }
}
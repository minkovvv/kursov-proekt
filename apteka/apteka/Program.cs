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
        // Spisuk sus stoki v magazina
        static List<Stoka> magazin = new List<Stoka>();

        static void Main(string[] args)
        {
            // Glaven cikul za izbirane na deistvie ot potrebitelq
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

                // Proverka na vavedenata opciq i izvejdane
                if (izbor == "1")
                    DobaviStoka(); // Dobavq nova stoka kum spisuka
                else if (izbor == "2")
                    PokajiStoki(); // Pokazva vsichkite stoki
                else if (izbor == "3")
                    SortiranePoIme(); // Sortira stokite po ime
                else if (izbor != "4")
                    Console.WriteLine("Nevaliden izbor!"); // Ako opciqta ne e validna
            }
            while (izbor != "4"); // Izliza pri izbor 4
        }

        // Funkciq za dobavqne na nova stoka kum magazina
        static void DobaviStoka()
        {
            Console.Write("Vuvedete ime na hranata/stokata (do 10 simvola): ");
            string ime = Console.ReadLine();

            // Proverka za dulzhinata na imeto
            if (ime.Length > 10)
            {
                Console.WriteLine("Imeto e tvurde dulgo!");
                return;
            }

            Console.Write("Vid jivotno (kuche / kotka / drugo): ");
            string vid = Console.ReadLine();

            // Dobavq nov tip Stoka kum spisuka
            magazin.Add(new Stoka { Ime = ime, VidZivotno = vid });
            Console.WriteLine("Uspeshno dobavena stoka.");
        }

        // Funkciq za pokazvane na vsichki stoki
        static void PokajiStoki()
        {
            Console.WriteLine("\n--- Spisuk na vsichki stoki ---");

            // Proverka dali ima dobaveni stoki
            if (magazin.Count == 0)
            {
                Console.WriteLine("Nqma vuvedeni stoki.");
            }
            else
            {
                // Izvezhdane na vsichki stoki
                foreach (var stoka in magazin)
                {
                    stoka.Print();
                }
            }
        }

        // Funkciq za sortirane na stoki po ime v azbuchen red
        static void SortiranePoIme()
        {
            Console.WriteLine("\n--- Sortirani stoki po ime ---");

            // Sortira spisuka po azbuchen red i go zapazva v nov spisuk
            var sortirani = magazin.OrderBy(s => s.Ime).ToList();

            // Izvezhdane na sortiraniq spisuk
            foreach (var stoka in sortirani)
            {
                stoka.Print();
            }
        }
    }
}

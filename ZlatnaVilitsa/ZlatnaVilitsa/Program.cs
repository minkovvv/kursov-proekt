using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlatnaVilitsa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Suzdavane na obekti
            klient k = new klient();
            poruchka p = new poruchka();
            plashtane pay = new plashtane();

            // Vavezhdane na danni
            Console.Write("Ime na klienta: ");
            k.ime = Console.ReadLine();

            Console.Write("Broi hora: ");
            k.broiHora = int.Parse(Console.ReadLine());

            Console.Write("Nomer na masa: ");
            k.masa = int.Parse(Console.ReadLine());

            Console.Write("Ime na qstieto: ");
            p.imeNaQstie = Console.ReadLine();

            Console.Write("Broi porcii: ");
            p.broiPorcii = int.Parse(Console.ReadLine());

            Console.Write("Tip na qstieto (predqstie, osnovno, desert): ");
            p.tipQstie = Console.ReadLine();

            Console.Write("Cena na porcia: ");
            pay.cenaNaPorcia = double.Parse(Console.ReadLine());

            Console.Write("Nachin na plashtane (cash, karta, online): ");
            pay.nachinNaPlashtane = Console.ReadLine();

            // Izchislyavane na krayna cena
            double kraynaCena = p.broiPorcii * pay.cenaNaPorcia;

            // Izhod
            Console.WriteLine("\n--- Obobshtena informaciq ---");
            Console.WriteLine($"Klient: {k.ime}");
            Console.WriteLine($"Broi hora: {k.broiHora}");
            Console.WriteLine($"Masa {k.masa}");
            Console.WriteLine($"Qstie: {p.imeNaQstie}");
            Console.WriteLine($"Broi porcii: {p.broiPorcii}");
            Console.WriteLine($"Tip qstie: {p.tipQstie}");
            Console.WriteLine($"Cena na porcia: {pay.cenaNaPorcia} lv.");
            Console.WriteLine($"Nachin na plashtane: {pay.nachinNaPlashtane}");
            Console.WriteLine($"Kraina cena za masa {k.masa}: {kraynaCena:F2} lv.");

            // Dopulnitelni proverki
            if (p.tipQstie == "predqstie")
            {
                Console.WriteLine($"\n[Predqstie] Qstie: {p.tipQstie}, Porcii: {p.broiPorcii}, Masa {k.masa}");
            }

            if (p.tipQstie == "osnovno")
            {
                Console.WriteLine($"\n[Osnovno] Broi hora: {k.broiHora}, Masa {k.masa}");
            }

            if (k.masa > 10)
            {
                Console.WriteLine($"\n[Masa > 10] Masa {k.masa}, Cena: {kraynaCena:F2} lv.");
            }
        }
    }
}



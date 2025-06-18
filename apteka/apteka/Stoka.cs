using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apteka
{
    internal class Stoka
    {
        public string Ime { get; set; }
        public string VidZivotno { get; set; }

        public void Print()
        {
            Console.WriteLine($"Ime: {Ime}, Vid jivotno: {VidZivotno}");
        }
    }
}

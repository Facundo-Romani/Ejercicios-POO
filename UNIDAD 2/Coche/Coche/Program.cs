using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coche coche = new coche(); // Objeto
            coche.getDimensiones(); // Nomenclatura del punto
            coche.setExtras("Cuero",true);

            Console.WriteLine(coche.getDimensiones());
            Console.WriteLine(coche.getExtras());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();
            pokemon1.Nombre = "Pikachu";

            Pokemon pokemon2 = new Pokemon();
            pokemon2.Nombre = "Ratatui";

            Pokemon pokemon3 = new Pokemon();
            pokemon3.Nombre = "Charmander";

            List<Pokemon> listaDePokemones = new List<Pokemon>();
            listaDePokemones.Add(pokemon1);
            listaDePokemones.Add(pokemon2);
            listaDePokemones.Add(pokemon3);


            //Console.WriteLine(listaDePokemones.Count); // Count contar elementos de mi lista.
            //listaDePokemones.Remove(pokemon3); // Remove remover elemento de mi lista.
            //Console.WriteLine(listaDePokemones.Count); 
            //Console.WriteLine(listaDePokemones[0].Nombre);
            //Console.ReadKey();

            // Recorrer lista de Pokemones.
            foreach (var item in listaDePokemones)
            {
                Console.WriteLine(item.Nombre);
            }
            
            Console.ReadKey();
        }
    }
}


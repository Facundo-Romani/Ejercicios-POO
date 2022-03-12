using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Pikachu pokemon1 = new Pikachu();
            //pokemon1.ClaseDePokemon = "Electro";

            //Squirtle pokemon2 = new Squirtle();
            //pokemon2.ClaseDePokemon = "Agua";

            //Console.WriteLine("Pikachu es un tipo: " + pokemon1.ClaseDePokemon);
            //Console.WriteLine("Sus Puntos de Ataque son: " + pokemon1.PuntosDeAtaque(500) + " Sus Puntos de Defensa son: " + pokemon1.PuntosDeDefensa(50));
            //Console.WriteLine(pokemon1.ataque());
            //Console.WriteLine("Squirtle es un tipo: " + pokemon2.ClaseDePokemon);
            //Console.WriteLine("Sus Puntos de Ataque son: " + pokemon2.PuntosDeAtaque(350) + " Sus Puntos de Defensa son: " + pokemon2.PuntosDeDefensa(250));
            //Console.WriteLine(pokemon2.ataque());
            //Console.ReadKey();            

            List<Pokemon> pokemones = new List<Pokemon>();
            pokemones.Add(new Pikachu());
            pokemones.Add(new Squirtle());

            // List de Interfaz.
            List<AtaqueAdistancia> listaAtacantesEnDistancia = new List<AtaqueAdistancia>();
            listaAtacantesEnDistancia.Add(new Pikachu());

            foreach (var item in pokemones)
            {
                Console.WriteLine(item.ataque());  // Polimorfismo con un estimulo diferentes reacciones.
            }

            Console.ReadKey();
             
        }
    }
}

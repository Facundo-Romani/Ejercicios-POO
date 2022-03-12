using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto.
            PokemonGo pikachu = new PokemonGo();
            pikachu.PuntosDeataques = 500;
            pikachu.PuntosDeDefensa = 200;

            Console.WriteLine("El pokemon Pikachu tiene: " + pikachu.PuntosDeataques + " Puntos de ataque");
            Console.WriteLine("El pokemon Pikachu tiene: " + pikachu.PuntosDeDefensa + " Puntos de defensa");
            Console.ReadKey();  

            // Segundo Objeto.
            Pokebola pokebola1 = new Pokebola();
            pokebola1.Almacenamiento = 10;

            Console.WriteLine("El almacenamiento en pokebola es: " + pokebola1.Almacenamiento);
            Console.ReadKey();
        }
    } 
  
}

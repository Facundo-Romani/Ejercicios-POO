using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasUnidad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRIMER EJEMPLO DE OBJETO.

            Pokemon pikachu = new Pokemon(); // Crear variable tipo pokemon.
                                             // Creando el objeto new Pokemon.
            pikachu.setPuntosDeAtaque(500); // Setear los puntos de ataque.
                                            // Mostrar en Consola.
            Console.WriteLine("Los puntos de Ataque de pikachu son: " + pikachu.getPuntosDeAtaque());
            Console.ReadKey();   
        
          //SEGUNDO EJEMPLO DE OBJETO. 

            botella botella1 = new botella();  //Objeto
            botella1.Capacidad = 500; // Objeto. accedo a la propiedad capacidad.
            int finalDeCapacidad = botella1.Capacidad; // Asigno valor capacidad a otra variable.

            Console.WriteLine("La capacidad de la botella es: " + finalDeCapacidad);
            Console.ReadKey();
        }
    } 
}

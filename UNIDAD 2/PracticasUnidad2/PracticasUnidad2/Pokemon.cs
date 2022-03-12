using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasUnidad2
{
    internal class Pokemon
    {
        private string tipoDePokemon; // Atributos de la clase Pokemon.
        private int puntosDeAtaque;    // Encapsulados PRIVATE.
        private int puntosDeDefensa;  
    
        public void setPuntosDeAtaque (int puntos) // Metodo set pasarle los puntos.
        {
            puntosDeAtaque = puntos;
        }

        public int getPuntosDeAtaque () // Metodo para extraer puntos de ataque, solo retorna.
        {
            return puntosDeAtaque;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pokebola
    {
        // Atributos.
        private int capacidadDePokemones;
        
        // Metodo del atributo.
        public int Almacenamiento
        {
            get { return capacidadDePokemones;}
            set { capacidadDePokemones = value; }
        }
    }
}

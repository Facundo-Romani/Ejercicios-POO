using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Pikachu : Pokemon ,AtaqueAdistancia
    {
        public override string ataque()
        {
            return "Ataque De Rayo";
        }

        // Interfaz metodo.

        public string ataqueDistancia()
        {
            return "Puede Atacar a Distancia";
        }
    }
}

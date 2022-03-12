using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_unidad2
{
    internal class Botella
    {
        // Constructor.
        public Botella (string color, string medida)
        {
            this.color = color;
            this.medida = medida;
            capacidad = 100;
        }
        // Sobrecarga de constructor.
        public Botella() { }

        // Atributos de la clase.
        private string color;
        private string medida;
        private int capacidad;

      
    }
        
}

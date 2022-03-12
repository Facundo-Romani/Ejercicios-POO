using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_unidad2
{
    internal class Articulo
    {
        // Crear propiedad y atributo en la misma linea de codigo, de manera public.
        public int CodigoDeArticulo { get; set; } // Manera corta de escribir.
        
        public double Precio { get; set; }  

        // Crear el atributo privado.
        private int codigoDeMarca;  // Tiene que ser valor en rangos de 1 a 10.
        public int CodigoDeMarca {         // Metodo, propiedad publica del atrubuto CodigoMarca.
            get { return codigoDeMarca; } 
            set {
                if (value > 0 && value < 11) // Condicion si el valor que se ingresa es mayor a 0.
                    codigoDeMarca = value;   // Y menor a 11.
                else
                    codigoDeMarca = -1; // Error.   
            }
        }

    }
}
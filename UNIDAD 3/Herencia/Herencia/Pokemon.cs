using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Pokemon
    {   
        //Propiedades.
        public string ClaseDePokemon { get; set; }
        
        // Metodos con Parametros.
        public int PuntosDeAtaque(int puntosAtaque) 
        {
            return puntosAtaque;
        }
        public int PuntosDeDefensa(int puntosDefensa) 
        {
            return puntosDefensa;
        } 

        // Sobreescritura de Metodos con Virtual.
        public virtual string ataque()
        {
            return "Rush";
        }
    }
}

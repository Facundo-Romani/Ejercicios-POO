using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche
{
    internal class coche
    {   
        // Constructor.
        public coche()
        {
            altura = 2; // Dar un estado inicial a las propiedades del objeto.
            ancho = 3;
        }
        
        // Metodos de acceso a las propiedades de la clase coche.
        // Metodo get (siempre retorna algo y es publico)
        public string getDimensiones()
        {
            return "Las Dimensiones del coche son: " + altura + " Ancho: " + ancho;          
        }

        // Metodo set es de tipo void no retorna nada.  
        public void setExtras(string tapizado, bool climatizador)
        {
            this.tapizado = tapizado; // Recibe los parametros desde el ebjeto.
            this.climatizador = climatizador; 
        }

        public string getExtras() 
        { 
            return "Extras del Coche: \n Tapizado: " + tapizado + " Climatizador: " + climatizador;
        }

        // Propiedades de coche.
        private int altura;
        private int ancho;
        private string tapizado;
        private bool climatizador;
    }
}

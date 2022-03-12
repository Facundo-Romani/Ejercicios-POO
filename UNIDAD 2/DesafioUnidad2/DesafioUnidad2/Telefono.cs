using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUnidad2
{
    internal class Telefono
    {   
        // Atributos.
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        // Propiedades.
        public string GetModelo
        {
            get { return modelo; }
        }

        public string GetMarca
        {
            get { return marca; }
        }

        public string NumeroTelefono{
            get { return numeroTelefonico; }
            set { numeroTelefonico = value;}
        } 

        public int CodigoOperador
        {
            get { return codigoOperador;}
            set { 
                    if (value > 1 && value <= 3) 
                        codigoOperador = value; 
                    else
                        codigoOperador = 0; }
        }

        // Constructor.
        public Telefono(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        // Metodo Llamar.
        public string llamar()
        {
            return "Realizando llamada...";
        }

        // Sobrecarga de constructor.
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }

    }
}

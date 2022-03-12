using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUnidad2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Crear el objeto celular instanciarlo y pasarle parametros para que llame al metodo de la clase telefono.
            Telefono celular = new Telefono("Motorola" ,"E6plus");

            Console.WriteLine("Digite Codigo de tres digitos");
            celular.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero de celular");
            celular.NumeroTelefono = Console.ReadLine();
            Console.WriteLine("La Marca de celular es: " + celular.GetMarca + " El Modelo de celular es: " + celular.GetModelo);
            Console.WriteLine(celular.llamar());
            Console.WriteLine(celular.llamar("Facundo"));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_unidad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objeto Articulo.
            // Articulo articulo1 = new Articulo();
            // articulo1.CodigoDeArticulo = 001;
            // articulo1.Precio = 40.50;
            // articulo1.CodigoDeMarca = 10; // Al pasarle el valor el metodo evalua con la condicion del set.

            // GENERAR UN VECTOR/ OBJETOS DE 10 ARTICULOS, PARA ALMACENARLOS.
            Articulo[] articulos = new Articulo[10];
            // articulos[0].CodigoDeMarca = 5;  // Articulos en el indice 0 le asigno el valor 5.
            
            // Cargar datos de los Articulos que ingresa el usuario con un for.
            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo(); // Cargar vector dentro del ciclo.

                Console.WriteLine("Ingresa los datos del producto" );
                Console.WriteLine("Codigo del producto");
                articulos[x].CodigoDeArticulo = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Precio del Articulo");
                articulos[x].Precio = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Codigo de Marca");
                articulos[x].CodigoDeMarca = int.Parse(Console.ReadLine());

                Console.ReadKey();
            }

            // Cargar la venta.
            Venta venta = new Venta();

            Console.WriteLine("INGRESA LA VENTA");
            Console.WriteLine("Ingresa Codigo de cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Codigo de Articulo");
            venta.CodigoDeArticulo= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Cantidad de artuculos");
            venta.Cantidad = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Ingresa Codigo de Articulo");
                venta.CodigoDeArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa Cantidad de artuculos");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // Pido ingreso de Venta.
                Console.WriteLine("INGRESA LA VENTA");
                Console.WriteLine("Ingresa Codigo de cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }
        }
    }
}

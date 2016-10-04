using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoParcial
{
    class Program
    {
        static void Main()
        {
            Estante est1 = new Estante(3);
            Estante est2 = new Estante(2);

            Producto p = new Producto(222, EMarcaProducto.Manaos, 50.25f);
            Galletita g1 = new Galletita(113, 33.65f, EMarcaProducto.Pitusas, 250f);
            Galletita g2 = new Galletita(111, 56f, EMarcaProducto.Diversion, 500f);
            Jugo j1 = new Jugo(112, 25f, EMarcaProducto.Naranju, ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, 33f, EMarcaProducto.Swift, ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(p, 2250f);

            if (est1 + g1)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (est1 + g2)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (est1 + g1)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (est1 + j1)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }

            if (est2 + g)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (est2 + p)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (est2 + j2)
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }

            //Console.WriteLine(est1.ValorEstanteTotal);
           // Console.WriteLine(est1.GetValorEstante(ETipoProducto.Galletita));
            Console.WriteLine(Estante.MostrarEstante(est1));

            //Console.WriteLine("Estante ordenado....");
            //est1.GetProductos().Sort(Program.OrdenarProductos);
            Console.WriteLine(Estante.MostrarEstante(est1));


            est1 = est1 - ETipoProducto.Galletita;
            Console.WriteLine(Estante.MostrarEstante(est1));

            Console.ReadLine();

            Console.WriteLine(Estante.MostrarEstante(est2));
            est2 -= ETipoProducto.Todos;
            Console.WriteLine(Estante.MostrarEstante(est2));

            Console.ReadLine();

        }

        private static int OrdenarProductos(Producto p, Producto p1)
        {
            return String.Compare(((int)p).ToString(), ((int)p1).ToString());
        }
     }
}


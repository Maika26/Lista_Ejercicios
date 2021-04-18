using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un número del 1 al 12: ");
            n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Enero");
            }
            else if (n == 2)
            {
                Console.WriteLine("Febrero");
            }
            else if (n == 3)
            {
                Console.WriteLine("Marzo");
            }
            else if (n == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (n == 5)
            {
                Console.WriteLine("Mayo");
            }
            else if (n == 6)
            {
                Console.WriteLine("Junio");
            }
            else if (n == 7)
            {
                Console.WriteLine("Julio");
            }
            else if (n == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (n == 9)
            {
                Console.WriteLine("Septiembre");
            }
            else if (n == 10)
            {
                Console.WriteLine("Octubre");
            }
            else if (n == 11)
            {
                Console.WriteLine("Noviembre");
            }
            else if (n == 12)
            {
                Console.WriteLine("Diciembre");
            }
            else
            {
                Console.WriteLine("Error al ingresar número");
            }

            Console.ReadLine();
        }
    }
}

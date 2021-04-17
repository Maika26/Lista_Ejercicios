using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.ReadLine();
            if (numero % 2 == 0 )
            {
                Console.WriteLine("numero par");
            }
            else
            {
                Console.WriteLine("numero impar");
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1404
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese su nota: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= 7)
            {
                Console.WriteLine("Nota correcta");
            }
            else
            {
                Console.WriteLine("Nota fuera de rango");
            }
            Console.ReadLine();


        }
    }
}

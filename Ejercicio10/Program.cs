using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int nuno;
            int ndos;
            Console.WriteLine("Ingrese el primer número: ");
            nuno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            ndos = int.Parse(Console.ReadLine());
            if(nuno % 2 == 0 && ndos % 2 != 0)
            {
                Console.WriteLine("Par e impar");
            }
            else if(nuno % 2 == 0 && ndos % 2 == 0)
            {
                Console.WriteLine("Par y par");
            }
            else if(nuno % 2 != 0 && ndos % 2 == 0)
            {
                Console.WriteLine("Impar y par");
            }
            else
            {
                Console.Write("Impar e impar");
            }

            Console.ReadLine();
        }
    }
}

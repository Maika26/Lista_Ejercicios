using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            Console.ReadLine();
            for(int x = 1; x <= num; x+=2)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

        }
    }
}

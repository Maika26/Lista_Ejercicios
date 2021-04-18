using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu;
            int nd;
            
            Console.WriteLine("Ingrese el primer número: ");
            nu = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            nd = int.Parse(Console.ReadLine());
            for(int x=nu; x>nd; nd++)
            {
                if (x > nd)
                {
                    Console.WriteLine(nd);
                }
                else
                {
                    Console.WriteLine(nu++);
                }
            }
            



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.WriteLine("Ingrese una nota entre el 1 y el 7: ");
            nota = int.Parse(Console.ReadLine());
            while (nota < 1 && nota > 7)
            {
                Console.WriteLine("Ingrese una nota entre el 1 y el 7: ");
            }
            Console.WriteLine("La nota es válida");    

            Console.ReadLine();
        }
    }
}

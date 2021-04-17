using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            double h = 6;
            double v;
            Console.WriteLine("Ingrese la distancia en km a recorrer en 6 horas: ");
            d = double.Parse(Console.ReadLine());
            Console.ReadLine();
            v = d / 6;

            Console.WriteLine("La velocidad a la que se desplazará el vehículo es de: "+v+"km/h");

            Console.ReadLine();
        }
    }
}

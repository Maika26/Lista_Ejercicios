using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            double v;
            Console.WriteLine("Ingrese la distancia en km a recorrer en 6 horas: ");
            d = double.Parse(Console.ReadLine());
            Console.ReadLine();
            v = d / 6;
            if(v > 100)
            {
                Console.Write("El vehículo se desplaza a gran velocidad: "+v+"km/h");
            }
            else
            {
                Console.WriteLine("El vehículo se desplaza a velocidad moderada: "+v+"km/h");
            }

            Console.ReadLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto;
            int cuotas;
            int interes;
            int montoTotal;
            int valorCuota;
            Console.WriteLine("Ingrese el monto a solicitar: ");
            monto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de cuotas en las que quiere pagar: ");
            cuotas = int.Parse(Console.ReadLine());
            if(cuotas>= 1 && cuotas <= 12)
            {
                interes = (monto * 10) / 100;
                montoTotal = monto + interes;
                valorCuota = montoTotal / cuotas;
                Console.WriteLine("El total a pagar es de: "+montoTotal);
                Console.WriteLine("El valor de cada cuota es de: "+valorCuota);
            }
            else if(cuotas>=13 && cuotas <= 30)
            {
                interes = (monto * 25) / 100;
                montoTotal = monto + interes;
                valorCuota = montoTotal / cuotas;
                Console.WriteLine("El total a pagar es de: "+montoTotal);
                Console.WriteLine("El valor de cada cuota es de: "+valorCuota);
            }
            else if(cuotas>=31 && cuotas <= 40)
            {
                interes = (monto * 35) / 100;
                montoTotal = monto + interes;
                valorCuota = montoTotal / cuotas;
                Console.WriteLine("El total a pagar es de: "+montoTotal);
                Console.WriteLine("El valor de cada cuota es de: "+valorCuota);
            }
            else
            {
                interes = (monto * 50) / 100;
                montoTotal = monto + interes;
                valorCuota = montoTotal / cuotas;
                Console.WriteLine("El total a pagar es de: "+montoTotal);
                Console.WriteLine("El valor de cada cuota es de: "+valorCuota);
            }

            Console.ReadLine();
        }
    }
}

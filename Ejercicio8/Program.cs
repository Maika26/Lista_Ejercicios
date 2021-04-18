using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número del 1 al 7: ");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (num == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (num == 3)
            {
                Console.WriteLine("Miercoles");
            }
            else if (num == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (num == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (num == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (num == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Error al ingresar número");
            }

            Console.ReadLine();
        }
    }
}

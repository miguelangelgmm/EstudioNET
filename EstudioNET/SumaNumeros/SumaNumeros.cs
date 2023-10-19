using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros
{
    internal class SumaNumeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de los números es:" + (num1 + num2));

            // Esperar a que el usuario presione una tecla antes de salir
            Console.ReadKey();

        }
    }
}

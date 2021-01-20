using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double m = (y2 - y1) / (x2 - x1);
            Console.WriteLine("La pendiente es igual a:" + m);

            double b = (y1 - m * x1);
            Console.WriteLine("El intercepto es igual a: " + b);

            double d = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("La distancia entre los dos puntos es igual a: " + d);

        }
    }
}

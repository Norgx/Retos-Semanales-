using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserte a: ");
            double a = double.Parse(Console.ReadLine());

            double aRad = a * (Math.PI / 180.0);
            double z = Math.Cos(aRad) * t;
            double c = (Math.PI) - (Math.PI / 2) - aRad;
            double y = (z / Math.Tan(c));
            double cg = c * (180.0 / Math.PI);

            Console.WriteLine("Z = " + z);
            Console.WriteLine("C = " + cg);
            Console.WriteLine("Y = " + y);

        }
    }
}

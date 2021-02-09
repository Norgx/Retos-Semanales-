using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Y y Z: ");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt(z * z + y * y);
            double a = Math.Acos(z / t);
            double c = Math.PI - (Math.PI / 2) - a;

            double aGrados = a * (180.0 / Math.PI);
            double cGrados = c * (180.0 / Math.PI);

            Console.WriteLine(" t= " + t);
            Console.WriteLine(" a= " + aGrados);
            Console.WriteLine(" c= " + cGrados);

        }
    }
}

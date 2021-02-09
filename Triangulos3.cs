using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte C y Z: ");
            double c = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double cg = c * (Math.PI / 180.0);
            double y = (z / Math.Tan(cg));
            double t = Math.Sqrt(y * y + z * z);
            double a = Math.Atan(y / z);
            double ag = a * (180.0 / Math.PI);

            Console.WriteLine("y= " + y);
            Console.WriteLine("t= " + t);
            Console.WriteLine("a= " + ag);
        }
    }
}

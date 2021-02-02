using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());

            double smmlv = 908526;

            double dossmmlv = (2 * smmlv);
            double cincosmmlv = (5 * smmlv);

            double cuota1 = 3500;
            double cuota2 = 14000;
            double cuota3 = 36800;

            Console.WriteLine("Su tarifa es: ");
            
            if (salario < dossmmlv) 
            {
                Console.WriteLine("Tarifa A: " );
            }
            if (dossmmlv <= salario && salario < cincosmmlv) 
            {
                Console.WriteLine("Tarifa B: " + cuota2);
            }
            if (salario >= cincosmmlv) 
            { 
                Console.WriteLine("Tarifa C: " + cuota3);
            }
        
        }
    }
}

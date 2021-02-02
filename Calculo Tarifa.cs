using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");

            double salario = double.Parse(Console.ReadLine());

            double smmlv = 908526;

            double dossmmlv = (2 * smmlv);

            double cuatrosmmlv = (4 * smmlv);

            Console.WriteLine("Su tarifa a pagar es: ");

            if (salario < dossmmlv)
            {
                Console.WriteLine("Tarifa A");
            }
            if (dossmmlv <= salario && salario < cuatrosmmlv)
            {
                Console.WriteLine("Tarifa B");
            }
            if (salario >= cuatrosmmlv)
            {
                Console.WriteLine("Tarifa C");
            }

        }
    }
}

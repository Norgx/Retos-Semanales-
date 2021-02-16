using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_Extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0; //resultado 
            Console.WriteLine(" Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombreMax = "";
            string nombreMin = "";



            while (i < n) 
            {
                Console.WriteLine("Ingrese el nombre y la edad: ");
                string nombre = Console.ReadLine();
                int edad = int.Parse(Console.ReadLine());

                if (edad > max) 
                {
                    max = edad;
                    nombreMax = nombre;
                    
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMin = nombre;
                }

                total += edad;

                i++;


            }
            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = "  + max + "," + nombreMax);
            Console.WriteLine("Minimo = " + min + "," + nombreMin);
        }
    }
}
//vid: https://youtu.be/cPdHZufvGyo
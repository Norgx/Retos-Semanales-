using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro2_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int t = 0, n = 0, dado = 0, total = 0; //t = turno

            Console.WriteLine("¿Desea iniciar el juego?  (s / n)");
            string respuesta = Console.ReadLine();

            while ((respuesta == "s")) 
            {
                dado = aleatorio.Next(1, 13);
                t++;
                total += dado;
                Console.WriteLine("Dado : " + dado + "\nTotal: " + total);
                Console.WriteLine("Turno: " + t);

                if (total >= 100)
                {
                    Console.WriteLine("Felicidades, ha ganado el juego");
                    break;
                }
                if(dado == 12)
                {
                    n++; 
                }
                if (n== 1 && dado == 10)
                {
                    Console.WriteLine("Has ganado (sacaste un 12 seguido de un 10)");
                    break;
                }
                else if (t > 3)
                {
                    if (dado % 2 != 0) ;
                    {
                        Console.WriteLine("Has perdido; sacaste un número impar");
                        break;
                    }
                }

                Console.WriteLine("¿Desea continuar? (s/n)");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("GRACIAS POR JUGAR");
        }
    }
}

// Video : https://youtu.be/jwfsS4mrhpw
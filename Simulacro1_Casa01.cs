using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro1_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0;
            int sumados = dado1 + dado2;
            double turno = 0;
            int tmayorseis = 0;
            int dobles = 0;

            Console.WriteLine("Desea iniciar el juego : (s / n)");
            string respuesta = Console.ReadLine();

            while ((respuesta == "s")) 
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);

                if (dado1 == dado2)
                {
                    dobles++;
                }
                if ((dado1 ==1) && dado2 ==1)
                {
                    sumados = 0;
                    Console.WriteLine("Usted ha sido eliminado" + ", \n Dado 1 = " + dado1 + ", \n Dado 2 = " + dado2);
                    respuesta = "no";
                }
                else if ( dobles == 3)
                {
                    Console.WriteLine("Felicidades, ha ganado el juego");
                    respuesta = "no";
                }
                else
                {
                    sumados += dado1 + dado2;
                    Console.WriteLine("Dado 1 : " + dado1 + ",\n Dado 2 : " + dado2 + ", \n Total = " + sumados);


                    if (sumados >= 100)
                    {
                        Console.WriteLine("Felicidades; ha ganado el juego ");
                        respuesta = "no";
                        break;
                    }
                    Console.WriteLine("¿Continuar? ");
                    respuesta = Console.ReadLine();
                }

                turno++;
                
                if (sumados > 6)
                {
                    tmayorseis++;
                }

                Console.WriteLine("Contador = " + tmayorseis);
                double porcentaje = (tmayorseis / turno) * 100;

                Console.WriteLine("Número de partidas: " + turno + "\n Porcentaje = " + porcentaje);
                Console.WriteLine("Gracias por jugar");
                respuesta = "no";
            }
            // video: https://youtu.be/a6i_7sB-ONU 


        }
    }
}

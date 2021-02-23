using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Multijugador
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorcartas1 = 0, valorcartas2 = 0, jugador = 1, min = 21, max = 0, ganador = 0, turno = 0;
            Console.WriteLine("Bienvenido, ingrese el número de jugadores: ");
            int respJugador = int.Parse(Console.ReadLine());

            while (respJugador < 2 || (respJugador > 5))
            {
                Console.WriteLine(" El número de jugadores no es válido, por favor intente de nuevo.");
                respJugador = int.Parse(Console.ReadLine());
            }

            while (respJugador >= jugador)
            {
                turno++;
                Console.WriteLine("Ha comenzado el juego" + "\nJugador: " + jugador);
                Random aleatorio = new Random();
                valorcartas1 = aleatorio.Next(1, 11);
                valorcartas2 = aleatorio.Next(1, 11);
                int total = valorcartas1 + valorcartas2;
                Console.WriteLine("El valor de su primera carta es: " + valorcartas1);
                Console.WriteLine("El valor de su segunda carta es: " + valorcartas2 + ",\nEl valor total es :" + total);
                string respuesta = "";
                Console.WriteLine("¿Continuar? (Pedir otra carta) " + ", (s/n)" + respuesta);
                respuesta = Console.ReadLine();

                while (respuesta != "s" && (respuesta != "n"))
                {
                    Console.WriteLine("Lo siento, esa no es una respuesta válida, intente otra vez");
                    respuesta = Console.ReadLine();
                }
                while (respuesta == "s")
                {
                    int nuevaCarta = aleatorio.Next(1, 11);
                    total += nuevaCarta;
                    Console.WriteLine("El valor de su nueva carta es: " + nuevaCarta);
                    Console.WriteLine("Su total es: " + total);

                    if (total < 21)
                    {
                        Console.WriteLine("¿Continuar? (s/n)");
                        respuesta = Console.ReadLine();
                        while (respuesta != "s" && (respuesta != "n"))
                        {
                            Console.WriteLine("Esa no es una respuesta válida; intente de nuevo: ");
                            respuesta = Console.ReadLine();
                        }
                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("Has ganado el juego");
                        respuesta = "n";
                    }
                    else
                    {
                        Console.WriteLine("Has sido eliminado");
                        respuesta = "n";
                    }

                }

                jugador += 1;
                Console.WriteLine("Gracias por jugar");

                if (total > max && total <= min)
                {
                    max = total;
                    ganador = turno;
                }
            }


            Console.WriteLine("Ganador : " + ganador + "\nTotal :" + max);
        }
    }
}

//Video: https://youtu.be/gh37j_cgWbw

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de BlackjAck");

            int carta1 = 0;
            int carta2 = 0;

            Random numAleatorio = new Random();
            carta1 = numAleatorio.Next(1, 10);
            carta2 = numAleatorio.Next(1, 10);
            int total = carta1 + carta2;

            Console.WriteLine("El valor de su primera carta es: " + carta1);
            Console.WriteLine("El valor de su segunda carta es: " + carta2);
            Console.WriteLine("El valor total de sus cartas es: " + total);

            string respuesta = "";
            Console.WriteLine("¿Continuar?(Pedir otra carta)" + ", (Si / No)" + respuesta);
            respuesta = Console.ReadLine();


        }
    }
}

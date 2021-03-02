using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadoSem7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego");
            int dado1 = 0, total = 0, vidas = 3, dadosEsp = 2, valDadosEsp = 0, contador = 0, contador2 = 0, turnos = 0;
                string respuesta = "";
            
            Random aleatorio = new Random();

            

            while (vidas > 0 && vidas <= 3)
            {
                
                if (dadosEsp > 0)
                {
                    Console.WriteLine("Actualmente tiene:  " + dadosEsp + ", dados especiales (12 caras)");
                    Console.WriteLine("¿Desea usar un dado especial? (s/n)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s")
                    {
                        dadosEsp -= 1;
                        valDadosEsp = aleatorio.Next(1, 13);
                        Console.WriteLine("Valor dado especial: " + valDadosEsp);
                        total += valDadosEsp;
                        Console.WriteLine("Total puntos: " + total);

                    }

                        if (dado1 == 1)
                        {
                            contador++;
                            if (contador == 2)
                            {
                                vidas -= 1;
                                Console.WriteLine("Vidas totales: " + vidas);
                                total -= 10;
                                Console.WriteLine("Total puntos: " + total);
                            }
                        }
                        if (dado1 == 6)
                        {
                            contador2++;

                            if (contador2 == 2)
                                vidas++;
                            Console.WriteLine("Vidas totales: " + vidas);

                        }

                        Console.WriteLine("¿Desea continuar el juego? (s/n)");
                        respuesta = Console.ReadLine();


                        if (respuesta == "s")
                        {
                            turnos++;
                            dado1 = aleatorio.Next(1, 6);
                            Console.WriteLine("Valor dado: " + dado1);
                            total += dado1;
                            Console.WriteLine("Total puntos: " + total);
                        }

                        if (vidas == 0)
                        {
                            Console.WriteLine("Lo siento, has perdido");
                            respuesta = "n";
                        }
                        else if (total >= 100)
                        {
                            Console.WriteLine("Felicidades, has ganado(alcanzaste el límite de puntos)");
                            respuesta = "n";
                        }

                    

                }



                // video:  https://youtu.be/d2sGKWLedv4



            }



        }
    }
}

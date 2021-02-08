using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_de_votos
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ingrese votos por partido 1: ");
			int a = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese votos por el partido 2: ");
			int b = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese votos en blanco: ");
			int blancos = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese votos anulados: ");
			int anulados = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese numero total de poblacion: ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese porcentaje de la poblacion que es mayor de edad: ");
			double p = int.Parse(Console.ReadLine());  //Porcentaje 

			int TotalVotantes = a + b + blancos + anulados;
			Console.WriteLine("Total de votantes: " + TotalVotantes);

			int adultos = (int)((p * n) / 100);
			Console.WriteLine("Adultos: " + adultos);

			int abstencion = adultos - TotalVotantes;
			Console.WriteLine("Abstencion: " + abstencion);

			int vvamasb = (a + b);

			bool Cond1 = anulados < vvamasb * 0.3;
			bool Cond2 = vvamasb > blancos;
			bool Cond3 = abstencion < TotalVotantes;


			if ((Cond1 || Cond2) && Cond3)
			{

				Console.WriteLine("Votacion exitosa");

				if (a < b)
				{

					Console.WriteLine("Ganador: Partido B");
				}

				else
				{
					Console.WriteLine("Ganador: Partido A");

				}
			}
			else
			{
				Console.WriteLine("Elecciones deben realizarse de nuevo");
			}
		}

	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria_2.IMC
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Calculo de IMC\n");

			Console.WriteLine("Ingrese su peso (Kg): ");
			double p = double.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese su altura(m): ");
			double a = double.Parse(Console.ReadLine());

			double IMC = p / (a * a);

			Console.WriteLine("\n Su IMC es: " + IMC);

			if (IMC < 18.5)
			{
				Console.WriteLine("\n Su peso es inferior al normal");
			}
			if (18.5 < IMC && IMC <= 24.9)
			{
				Console.WriteLine("\n Su peso es normal");
			}
			if (25 < IMC && IMC <= 29.9)
			{
				Console.WriteLine("\n Su peso es superior al normal");
			}
			if (IMC > 30)
			{
				Console.WriteLine("\n Usted tiene obesidad");
			}
		}

	}
}

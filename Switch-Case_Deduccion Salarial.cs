using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Deducción_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double SalarioMensual = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato: " + "Escriba 1 si es DEPENDIENTE " + ", Escribe 2 si es INDEPENDIENTE");
            int tipoContrato = int.Parse(Console.ReadLine());

            double smmlv = 908526;
            double baseCotizacion = SalarioMensual * 0.4;
            if (baseCotizacion < smmlv) baseCotizacion = smmlv;

            double pension = 0;
            double eps = 0;
            double arl = 0;
            double prima = 0;

            switch (tipoContrato)
            {
                case 1:

            pension = baseCotizacion * 0.4;
            eps = baseCotizacion * 0.4;
            prima = SalarioMensual;
            double SalarioReal = SalarioMensual - (pension + eps);
            double SalarioAnual = (SalarioReal * 12) + prima;

            Console.WriteLine("Deducciones: Eps: " + eps + ", Pension: " + pension);
            Console.WriteLine("Salario Real: " + SalarioReal + ", Salario Anual: " + SalarioAnual);break;

                case 2:

                    Console.WriteLine("Ingtese su número de riesgo: ");
                    int riesgo = int.Parse(Console.ReadLine());

                    pension = baseCotizacion * 0.16;
                    eps = baseCotizacion * 0.125;

                    switch (riesgo)
                    {
                        case 1: arl = 0.522 / 100; break;
                        case 2: arl = 1.044 / 100; break;
                        case 3: arl = 2.436 / 100; break;
                        case 4: arl = 4.350 / 100; break;
                        case 5: arl = 6.960 / 100; break;
                    }

                    arl *= baseCotizacion;
                    double SalarioReal2 = SalarioMensual - (pension + eps+ arl);
                    double SalarioAnual2 = (SalarioReal2 * 12);

                    Console.WriteLine("Deducciones: Eps: " + eps + ", Pension: " + pension + ", ARL: " + arl);
                    Console.WriteLine("Salario Real: " + SalarioReal2 + ", Salario Anual: " + SalarioAnual2); break;



        }
        }
    }
}
// video:https://youtu.be/szhsO6RvkyI
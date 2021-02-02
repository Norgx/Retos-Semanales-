using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deducción_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double SalarioMensual = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato: " + "Escriba 1, si es dependiente: " + "Escriba 2, si es independiente: ");
            int TipoContrato = int.Parse(Console.ReadLine());

            double SalarioMin = 908526;
            double BaseCot = SalarioMin * 0.4;

            if (BaseCot < SalarioMin) BaseCot = SalarioMin;
            if(TipoContrato == 1 )
            {
                double Pension = BaseCot * 0.4;
                double Eps = BaseCot * 0.4;
                double Prima = SalarioMensual;
                double SalarioReal = SalarioMensual - (Pension + Eps);
                double SalarioAnual = (SalarioReal * 12) + Prima;

                Console.WriteLine("Deducciones: EPS: " + Eps + " , Pension: " + Pension);
                Console.WriteLine("Salario Real: " + SalarioReal + ", Salario Anual: " + SalarioAnual);
                
            }
            if (TipoContrato == 2) 
            {
                Console.WriteLine("Ingrese su número de riesgo: ");
                int NumRiesgo = int.Parse(Console.ReadLine());

                if(NumRiesgo == 1)
                {
                    double Arl = BaseCot * 0.00522;
                    double Pension = BaseCot * 0.16;
                    double Eps = BaseCot * 0.125;
                    double SalarioReal = SalarioMensual - (Arl + Pension + Eps);
                    double SalarioAnual = SalarioReal * 12;

                    Console.WriteLine("Deducciones: EPS: " + Eps + " , Pension: " + Pension + ", ARL: " + Arl);
                    Console.WriteLine("Salario Real: " + SalarioReal + " , Salario Anual: " + SalarioAnual);

                }
                else if (NumRiesgo == 2)
                {
                    double Arl = BaseCot * 0.01044;
                    double Pension = BaseCot * 0.16;
                    double Eps = BaseCot * 0.125;
                    double SalarioReal = SalarioMensual - (Arl + Pension + Eps);
                    double SalarioAnual = SalarioReal * 12;

                    Console.WriteLine("Deducciones: EPS: " + Eps + " ,Pension: " + Pension + " , ARL: " + Arl);
                    Console.WriteLine("Salario Real: " + SalarioReal + ", Salario Anual: " + SalarioAnual);

                }
                else if (NumRiesgo == 3)
                {
                    double Arl = BaseCot * 0.02436;
                    double Pension = BaseCot * 0.16;
                    double Eps = BaseCot * 0.125;
                    double SalarioReal = SalarioMensual - (Arl + Pension + Eps);
                    double SalarioAnual = SalarioReal * 12;

                    Console.WriteLine("Deducciones: EPS: " + Eps + ", Pension: " + Pension + ", ARL: " + Arl);
                    Console.WriteLine("Salario Real: " + SalarioReal + ", Salario Anual: " + SalarioAnual);

                }
                else if (NumRiesgo == 4)
                {
                    double Arl = BaseCot * 0.04350;
                    double Pension = BaseCot * 0.16;
                    double Eps = BaseCot * 0.125;
                    double SalarioReal = SalarioMensual - (Arl + Pension + Eps);
                    double SalarioAnual = SalarioReal * 12;

                    Console.WriteLine("Deducciones: EPS: " + Eps + ", Pension: " + Pension + ", ARL: " + Arl);
                    Console.WriteLine("Salario Real: " + SalarioReal + ", Salario Anual: " + SalarioAnual);

                }
                else if (NumRiesgo == 5)
                {
                    double Arl = BaseCot * 0.06960;
                    double Pension = BaseCot * 0.16;
                    double Eps = BaseCot * 0.125;
                    double SalarioReal = SalarioMensual - (Arl + Pension + Eps);
                    double SalarioAnual = SalarioReal * 12;

                    Console.WriteLine("Deducciones: EPS: " + Eps + ", Pension: " + Pension + ", ARL: " + Arl);
                    Console.WriteLine("Salario Real: " + SalarioReal + ", Salario Anual: " + SalarioAnual);

                }
            }
        }
    }
}

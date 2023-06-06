using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Calcula_Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] b = new double[10];
            double[] e = new double[10];

            Random rand = new Random();
             for(int i = 0; i < b.Length; i++)
            {
                b[i] = rand.Next(-0, 1001);

             for(int j = 0; j < e.Length; j++)
            {
                e[j] = rand.Next(-0, 1001);
                
                Console.WriteLine("La potencia de {0} elevado a {1} es: {2} ", b[i], e[j], calcularPotencia(b, e));
            }

            }


        }

        public static double calcularPotencia(double[] arr1, double[] arr2)
        {
            double result = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    result = Math.Pow(arr1[i], arr2[j]);
                }
            }

            return result;
        }
    }
}

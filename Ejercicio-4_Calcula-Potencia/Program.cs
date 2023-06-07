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
            double result = 1;
            double negativeResult;

            Console.WriteLine("Introduce la base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el exponente: ");
            int exponent = int.Parse(Console.ReadLine());

            if(exponent < 0)
            {
                exponent = exponent * -1;

                for(int i = 1; i <= exponent; i++)
                {
                    result *= baseNum;
                }

                negativeResult = (1 / result);

                Console.WriteLine("{0}^{1} = {2}", baseNum, exponent, negativeResult);

            } else
            {
                for (int i = 1; i <= exponent; i++)
                {
                    result = result * baseNum;
                }

                Console.WriteLine("{0}^{1} = {2}", baseNum, exponent, result);
            }
            

        }


    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class CalculateFactorial
    {
        public static void Algorithm()
        {
            int factorial = 1;
            Console.Write("\nHangi Sayının Faktöriyelini Alalım?:  ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Sonuç: " + factorial + "\n");
        }
    }
}

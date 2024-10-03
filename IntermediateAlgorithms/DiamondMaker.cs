using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateAlgorithms
{
    public class DiamondMaker
    {
        public static void Algorithm()
        {
            Console.Write("Enter the number of levels: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Print the upper pyramid
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= (n - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Print the lower inverted pyramid
            for (int a = 1; a <= n; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * (n - a) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

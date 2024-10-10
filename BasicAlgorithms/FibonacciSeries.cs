using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class FibonacciSeries
    {
        public static void Algorithm()
        {
            int eleman, first = 0, second = 1, third;
            Console.Write("Fibonacci serisi eleman sayısı kaç olsun?: ");
            eleman = int.Parse(Console.ReadLine());
            Console.Write(first + " " + second);

            for (int i = 2; i < eleman; i++)
            {
                third = first + second;
                Console.Write(" " + third);
                first = second;
                second = third;
            }
            Console.WriteLine();
        }
    }
}

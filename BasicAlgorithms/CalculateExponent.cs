using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class CalculateExponent
    {
        public static void Algorithm()
        {
            Console.Write("\nTaban Değerini Giriniz: ");
            double baseValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üs Değerini Giriniz: ");
            double power = Convert.ToDouble(Console.ReadLine());

            double finalExponent = 1;

            for (int i = 1; i <= power; i++)
            {
                finalExponent *= baseValue;
            }

            Console.WriteLine("Sonuç: " + finalExponent);
            Console.WriteLine();
        }
    }
}

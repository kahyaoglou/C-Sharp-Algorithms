using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class CalculateCombination
    {
        public static void Algorithm()
        {
            int groupFactorial = 1, littleGroupFactorial = 1, finalFactorial = 1, combination;

            Console.Write("\nKümemiz Kaç Elemanlı?: ");
            int group = int.Parse(Console.ReadLine());

            Console.Write("Oluşacak Küme Kaç Elemanlı Olsun?: ");
            int littleGroup = int.Parse(Console.ReadLine());

            // Büyük küme faktöriyelini hesaplama
            for (int i = 1; i <= group; i++)
            {
                groupFactorial *= i;
            }

            // Küçük küme faktöriyelini hesaplama
            for (int j = 1; j <= littleGroup; j++)
            {
                littleGroupFactorial *= j;
            }

            // Büyük kümeden küçük küme çıkarılarak faktöriyel hesaplama
            for (int k = 1; k <= group - littleGroup; k++)
            {
                finalFactorial *= k;
            }

            // Kombinasyon hesaplama
            combination = groupFactorial / (littleGroupFactorial * finalFactorial);
            Console.WriteLine("Sonuç: " + combination + "\n");
        }
    }
}

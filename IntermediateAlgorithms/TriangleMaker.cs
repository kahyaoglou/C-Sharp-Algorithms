using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateAlgorithms
{
    public class TriangleMaker
    {
        public static void Algorithm()
        {
            Console.Write("Üçgenin Kat Sayısını Giriniz: ");
            int katSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= katSayisi; i++)
            {
                for (int k = 1; k <= (katSayisi - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

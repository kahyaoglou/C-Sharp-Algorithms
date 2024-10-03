using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class PerfectNumbers
    {
        public static void Algorithm()
        {
            int perfectNum, i = 1, total = 0;

            Console.Write("\nSayıyı Giriniz: ");
            perfectNum = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (perfectNum % i == 0)
                {
                    if (i != perfectNum)
                    {
                        total += i;
                    }
                }
                i++;
            } while (i <= perfectNum);

            if (total == perfectNum)
            {
                Console.WriteLine(perfectNum + " Mükemmel Sayıdır!\n");
            }
            else
            {
                Console.WriteLine(perfectNum + " Mükemmel Sayı Değildir.\n");
            }
        }
    }
}

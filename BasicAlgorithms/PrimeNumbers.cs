using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class PrimeNumbers
    {
        public static void Algorithm()
        {
            List<int> list = new List<int>();
            Console.Write("\nSayıyı Giriniz: ");

            int primeNum = int.Parse(Console.ReadLine());

            for (int i = 2; i <= primeNum; i++)
            {
                int control = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        control = i;
                        break;
                    }
                }
                if (control == 0)
                {
                    list.Add(i);
                }
            }

            if (list.Contains(primeNum))
            {
                Console.WriteLine($"{primeNum} asal sayıdır.\n");
            }
            else
            {
                Console.WriteLine($"{primeNum} asal sayı değildir.\n");
            }
        }
    }
}

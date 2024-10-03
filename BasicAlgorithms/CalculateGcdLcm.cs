using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class CalculateGcdLcm
    {
        private int num1, num2;

        public int ShowMenu()
        {
            Console.WriteLine("\nEBOB(1) / EKOK(2) / Geri(0)");
            Console.Write("Hangi Hesaplamayı Yapalım?: ");
            return int.Parse(Console.ReadLine());
        }

        public void GcdCalculator()
        {
            Console.WriteLine("\nEBOB...");
            Console.Write("İlk Sayıyı Giriniz: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            num2 = int.Parse(Console.ReadLine());

            int gcd = 1;

            for (int i = 1; i <= num1; i++)
            {
                if ((num1 % i == 0) && (num2 % i == 0))
                {
                    gcd = i;
                }
            }

            Console.WriteLine($"{num1} ve {num2}'nin EBOB'u: {gcd}\n");
        }

        public void LcmCalculator()
        {
            Console.WriteLine("\nEKOK...");
            Console.Write("İlk Sayıyı Giriniz: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            num2 = int.Parse(Console.ReadLine());

            int lcm = 1;
            int i = 1;

            while (i <= num1 * num2)
            {
                if ((i % num1 == 0) && (i % num2 == 0))
                {
                    lcm = i;
                    break;
                }
                i++;
            }

            Console.WriteLine($"{num1} ve {num2}'nin EKOK'u: {lcm}\n");
        }
    }
}

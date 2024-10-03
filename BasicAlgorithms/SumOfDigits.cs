using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class SumOfDigits
    {
        public static void Algorithm(int number)
        {
            int digitCount = 0; // Basamak sayısı.
            int tempNumber = number; // Geçici sayı.
            int digitValue; // Basamak değeri.
            int result = 0;

            while (tempNumber != 0)
            {
                tempNumber = tempNumber / 10;
                digitCount++;
            }

            tempNumber = number;

            while (tempNumber != 0)
            {
                digitValue = tempNumber % 10;
                result += digitValue;
                tempNumber = tempNumber / 10;
            }

            Console.WriteLine("Basamak toplamları: " + result);
        }

        public static int ShowMenu()
        {
            Console.Write("Basamaklarının toplamı hesaplanacak sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }
}

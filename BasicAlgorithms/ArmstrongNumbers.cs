using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class ArmstrongNumbers
    {
        public static void Algorithm()
        {
            Console.Write("\nSayıyı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int basamakNumber = 0; // Basamak sayısı
            int tempNumber = number; // Geçici sayı
            int basamakValue; // Basamak değeri
            int result = 0;
            int basamakPower;

            // Basamak sayısını bulma
            while (tempNumber != 0)
            {
                tempNumber /= 10;
                basamakNumber++;
            }

            tempNumber = number;

            // Son basamağı bulma ve hesaplama
            while (tempNumber != 0)
            {
                basamakValue = tempNumber % 10;
                basamakPower = 1;

                for (int i = 1; i <= basamakNumber; i++)
                {
                    basamakPower *= basamakValue;
                }

                result += basamakPower;
                tempNumber /= 10;
            }

            // Sonucun kontrolü
            if (result == number)
            {
                Console.WriteLine($"{number} sayısı bir Armstrong sayıdır.\n");
            }
            else
            {
                Console.WriteLine($"{number} sayısı bir Armstrong sayı değildir.\n");
            }
        }
    }
}

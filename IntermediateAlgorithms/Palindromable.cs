using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateAlgorithms
{
    public class Palindromable
    {
        public static void Algorithm()
        {
            Console.Write("Enter a word or number: ");
            string input = Console.ReadLine();

            // Tüm harfleri küçük harfe çeviriyoruz ve boşlukları kaldırıyoruz.
            input = input.ToLower();
            input = input.Replace(" ", "");

            // Harflerin frekansını saymak için bir dizi kullanıyoruz.
            int[] charCount = new int[256]; // ASCII karakter dizisi boyutu

            // Her harfin kaç defa tekrarlandığını sayıyoruz.
            foreach (char c in input)
            {
                charCount[c]++;
            }

            // Palindrom için en fazla bir tane harf tek sayıda olmalıdır.
            int oddCount = 0;

            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] % 2 != 0) // Eğer karakter sayısı tekse
                {
                    oddCount++;
                }

                // Eğer birden fazla tek karakter varsa, palindrom oluşturulamaz.
                if (oddCount > 1)
                {
                    Console.WriteLine("Palindrom olamaz :(");
                    return;
                }
            }

            Console.WriteLine("Palindrom olabilir!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    /*
     * Diyelim ki elinizde şu kitaplar var: [5, 2, 9, 1, 5, 6].
     * İlk olarak gap = 3 (her üçüncü kitap):
     *      Gruplar: [5, 1], [2, 5], [9, 6].
     *      Grupları sıralıyoruz: [1, 5], [2, 5], [6, 9].
     * Şimdi gap = 2 (her ikinci kitap):
     *      Gruplar: [5, 9], [2, 1], [5, 6].
     *      Grupları sıralıyoruz: [1, 2], [5, 5], [6, 9].
     * Son olarak gap = 1:
     *      Tüm diziyi gözden geçiriyoruz: [1, 2, 5, 5, 6, 9].
     */

    public class ShellSort
    {
        public static void Algorithm()
        {
            Console.Write("Kaç eleman gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Eleman {i + 1}'i giriniz: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array: ");
            Display(A);

            int gap = A.Length;
            while (gap > 0)
            {
                int i = gap;
                while (i < A.Length)
                {
                    int temp = A[i];
                    int j = i - gap;

                    while (j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }

                    A[j + gap] = temp;
                    i = i + 1;
                }

                gap = gap / 2;
            }

            Console.WriteLine("Sorted Array: ");
            Display(A);
            Console.ReadKey();
        }

        public static void Display(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        /* 
         * Diyelim ki elinizde şu kitaplar var: [5, 2, 9, 1, 5, 6].
         * Pivot olarak 5'i seçiyoruz.
         * Kitapları kontrol ediyoruz:
         * 2 < 5 → Sol tarafa
         * 1 < 5 → Sol tarafa
         * 9 > 5 → Sağ tarafa
         * Diğer 5 (eşit olduğu için sağa) ve 6 > 5 → Sağ tarafa
         * Şimdi gruplarımız: [2, 1] (solda) ve [5, 5, 6, 9] (sağda).
         * Bu gruplar için aynı işlemi tekrar ediyoruz.
         * Sonuçta, kitaplar sıralandığında elde edeceğiniz dizi: [1, 2, 5, 5, 6, 9].
         */

        public static void Algorithm()
        {
            Console.Write("Kaç eleman gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            for (int l = 0; l < n; l++)
            {
                Console.Write($"Eleman {l + 1}'i giriniz: ");
                A[l] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array: ");
            Display(A, A.Length); // Dizi uzunluğunu doğru verdik

            Sort(A, 0, A.Length - 1);

            Console.WriteLine("Sorted Array: ");
            Display(A, A.Length); // Dizi uzunluğunu doğru verdik
            Console.ReadKey();
        }

        public static void Sort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(A, low, high);
                Sort(A, low, pi - 1);
                Sort(A, pi + 1, high);
            }
        }

        public static int Partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && A[i] <= pivot)
                {
                    i = i + 1;
                }

                while (i <= j && A[j] > pivot)
                {
                    j = j - 1;
                }

                if (i <= j)
                {
                    Swap(A, i, j);
                }
            } while (i < j);
            Swap(A, low, j);
            return j;
        }

        public static void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static void Display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

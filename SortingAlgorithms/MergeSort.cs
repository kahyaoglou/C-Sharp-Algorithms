using System;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        /*
         * Özetle diziyi ikiye böleriz, çıkan dizileri de ikiye böleriz. 
         * Elde edilen parçalar 2 veya daha küçük eleman sayısına ulaştıysa dururuz, ulaşmadıysa bölmeye devam ederiz.
         * Elde ettiğimiz her bir parçayı kendi içinde sıralarız.
         * Her bölünmüş parçayı sırasına göre birleştiririz. Tek bir bütün olana dek parçaları birleştirmeye devam ederiz.
         * Tek bir bütün olduğunda dizi sıralanmış olacaktır.
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
            Display(A);

            MergeSortArray(A, 0, n - 1);

            Console.WriteLine("Sorted Array: ");
            Display(A);
            Console.ReadKey();
        }

        private static void MergeSortArray(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Sol ve sağ yarıları sıralayın
                MergeSortArray(A, left, mid);
                MergeSortArray(A, mid + 1, right);

                // Birleştir
                Merge(A, left, mid, right);
            }
        }

        private static void Merge(int[] A, int left, int mid, int right)
        {
            int i = left;   // Sol alt dizinin başlangıcı
            int j = mid + 1; // Sağ alt dizinin başlangıcı
            int k = left;   // Birleştirilmiş dizinin başlangıcı
            int[] B = new int[right + 1];

            // Elemanları karşılaştırarak birleştir
            while (i <= mid && j <= right)
            {
                if (A[i] <= A[j])
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
                k++;
            }

            // Kalan elemanları ekle
            while (i <= mid)
            {
                B[k] = A[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                B[k] = A[j];
                j++;
                k++;
            }

            // Birleştirilen diziyi ana diziye kopyala
            for (int x = left; x <= right; x++)
            {
                A[x] = B[x];
            }
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

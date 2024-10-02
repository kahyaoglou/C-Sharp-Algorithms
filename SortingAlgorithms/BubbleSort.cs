namespace SortingAlgorithms
{
    public class BubbleSort
    {
        /* 
         * Bubble sort, dizideki elemanları karşılaştırarak sıralayan basit bir sıralama algoritmasıdır.
         * İşleyişi, her iki komşu elemanı karşılaştırarak başlar.
         * Eğer soldaki eleman sağdakinden büyükse, bu elemanlar yer değiştirir.
         * Bu işlem, dizinin sonuna kadar devam eder.
         * Her geçişte en büyük eleman "baloncuk" gibi en sona yükselir.
         * Algoritma, tüm elemanlar sıralanana kadar bu geçişleri tekrarlar.
         * Genellikle O(n²) zaman karmaşıklığına sahiptir, bu da büyük dizilerde yavaş çalışabileceği anlamına gelir. 
         */

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

            // Sorting logic
            for (int pass = A.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
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

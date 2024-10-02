namespace SortingAlgorithms
{
    public class InsertionSort
    {
        /*
         * 5, 3, 12, 4 sayılarını ele alalım.
         * 5 sayısı kendini bir grup kabul eder ve kendini ayırır.
         * 3 Sayısı bu gruba dahil olur.
         * 3 sayısı grup içindeki diğer sayılarla (5) kendini kıyaslayarak en başa ilerler.
         * 12 sayısı gruba dahil olur ve gruptaki en büyük sayı olduğu için en sağda yerini alır,
         * 4 sayısı gruba dahil olur ve 3 ile 5 arasına yerleşir.
         * Sıralama başarılı bir şekilde gerçekleşir.
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
            for (int i = 1; i < A.Length; i++)
            {
                int temp = A[i];
                int position = i;

                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position = position - 1;
                }

                A[position] = temp;
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

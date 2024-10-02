namespace SortingAlgorithms
{
    public class SelectionSort
    {
        /*
         * Diyelim ki elinizde şu kitaplar var: [5, 2, 9, 1, 5, 6].
         * Tüm kitapları inceliyoruz ve en küçük kitabı buluyoruz. Burada 1 en küçük.
         * 1'i dizinin başına yerleştiriyoruz: [1, 2, 9, 5, 5, 6].
         * Şimdi sıradaki kitapları kontrol ediyoruz (2, 9, 5, 5, 6).
         * En küçük kitap yine 2. Zaten yerinde, o yüzden değişiklik yok.
         * Sıradaki en küçük kitap 5. Bunu 5 ile değiştiriyoruz, ama zaten 5 olduğu için değişiklik yok.
         * Kalan kitaplar: [5, 6, 9]. Buradan da 5'i buluyoruz ve yerinde, ardından 6 ve en son 9.
         * Sonuç olarak, kitaplar sıralandığında elde edeceğiniz dizi: [1, 2, 5, 5, 6, 9].
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

            for (int i = 0; i < A.Length - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[position])
                    {
                        position = j;
                    }
                }
                int temp = A[i];
                A[i] = A[position];
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

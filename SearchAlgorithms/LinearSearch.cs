namespace SearchAlgorithms
{
    public class LinearSearch
    {
        public static void Algorithm()
        {
            Console.Write("Kaç eleman gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            Console.WriteLine("Lütfen elemanları giriniz...");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Eleman {i + 1}'i giriniz: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Aranacak key value nedir? ");
            int key = Convert.ToInt32(Console.ReadLine());

            bool found = LinearSearchAlgorithm(A, key);
            Console.WriteLine("Sonuç: " + found);

            Console.ReadKey();
        }

        public static bool LinearSearchAlgorithm(int[] A, int key)
        {
            for (int index = 0; index < A.Length; index++)
            {
                if (A[index] == key)
                {
                    return true; // Return true if found
                }
            }
            return false; // Return false if not found
        }
    }
}

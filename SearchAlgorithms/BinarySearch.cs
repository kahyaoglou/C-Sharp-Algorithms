namespace SearchAlgorithms
{
    public class BinarySearch
    {
        public static void Algorithm()
        {
            Console.Write("Kaç eleman gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine(" Lütfen elemanları sıralı olarak giriniz...");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Eleman {i + 1}'i giriniz: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Aranacak key value nedir? ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hangi metot türü ile aramak istersen?");
            Console.WriteLine("1. Iterative");
            Console.WriteLine("2. Recursive");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    bool foundIterative = IterativeBinarySearch(A, key);
                    Console.WriteLine("Result: " + foundIterative);
                    break;
                case 2:
                    bool foundRecursive = RecursiveBinarySearch(A, key, 0, A.Length - 1);
                    Console.WriteLine("Result: " + foundRecursive);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                    break;
            }

            Console.ReadKey();
        }

        public static bool IterativeBinarySearch(int[] A, int key)
        {
            int left = 0;
            int right = A.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (key == A[mid])
                {
                    return true;
                }
                else if (key < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false; 
        }

        public static bool RecursiveBinarySearch(int[] A, int key, int left, int right)
        {
            if (left > right)
            {
                return false; 
            }

            int mid = (left + right) / 2;
            if (key == A[mid])
                return true;

            else if (key < A[mid])
                return RecursiveBinarySearch(A, key, left, mid - 1);

            else
                return RecursiveBinarySearch(A, key, mid + 1, right);
        }
    }
}

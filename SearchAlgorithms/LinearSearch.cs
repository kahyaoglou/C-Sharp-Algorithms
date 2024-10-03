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

            bool found = false;
            for (int index = 0; index < A.Length; index++)
            {
                if (A[index] == key)
                {
                    found = true;
                    break;
                }
            }

            Console.WriteLine(found ? "true" : "false");
        }
    }
}

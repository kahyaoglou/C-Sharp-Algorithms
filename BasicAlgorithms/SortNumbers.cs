namespace BasicAlgorithms
{
    public class SortNumbers
    {
        public static void Algorithm()
        {
            Console.Write("Kaç sayı girmek istiyorsunuz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Sayı {i + 1}'i giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sıralama işlemi
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sıralama: " + string.Join(" > ", numbers));
        }

    }
}

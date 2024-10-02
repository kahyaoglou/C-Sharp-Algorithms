using BasicAlgorithms;
using IntermediateAlgorithms;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Algoritma türünü seçiniz...");
            Console.WriteLine("Algoritmayı izlemek için breakpoint koymayı unutma :)");
            Console.WriteLine();
            Console.WriteLine("1. Basic Algorithms");
            Console.WriteLine("2. Intermediate Algorithms");
            Console.WriteLine("3. Sorting Algorithms");
            Console.WriteLine("4. Searching Algorithms");
            Console.WriteLine("5. Çıkış");

            int mainChoice = Convert.ToInt32(Console.ReadLine());

            switch (mainChoice)
            {
                case 1:
                    BasicAlgorithmMenu();
                    break;

                case 2:
                    IntermediateAlgorithmMenu();
                    break;

                case 3:
                    SortingAlgorithmMenu();
                    break;

                case 4:
                    SearchingAlgorithmMenu();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                    break;
            }
        }
    }

    static void BasicAlgorithmMenu()
    {
        while (true)
        {
            Console.WriteLine("Basic Algoritmalar:");
            Console.WriteLine("1. Girilen Numaraları Sıralama");
            Console.WriteLine("2. Basamak Değeri Toplamlarını Hesaplama");
            Console.WriteLine("3. Geri");

            int basicChoice = Convert.ToInt32(Console.ReadLine());
            switch (basicChoice)
            {
                case 1:
                    SortNumbers.Algorithm();
                    break;
                case 2:
                    SumOfDigits.Algorithm();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                    continue;
            }

            if (!AskToTryAgain())
                break;
        }
    }

    static void IntermediateAlgorithmMenu()
    {
        while (true)
        {
            Console.WriteLine("Intermediate Algoritmalar:");
            Console.WriteLine("1. Palindrom Öğrenme");

            int intermediateChoice = Convert.ToInt32(Console.ReadLine());
            if (intermediateChoice == 1)
            {
                IsPalindrome.IsPalindromeNumber();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                continue;
            }

            if (!AskToTryAgain())
                break;
        }
    }

    static void SortingAlgorithmMenu()
    {
        while (true)
        {
            Console.WriteLine("Sorting Algorithms:");
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine("3. Bubble Sort");
            Console.WriteLine("4. Shell Sort");
            Console.WriteLine("5. Merge Sort");
            Console.WriteLine("6. Quick Sort");
            Console.WriteLine("7. Geri");

            int sortChoice = Convert.ToInt32(Console.ReadLine());
            switch (sortChoice)
            {
                case 1:
                    SortingAlgorithms.SelectionSort.Algorithm();
                    break;
                case 2:
                    SortingAlgorithms.InsertionSort.Algorithm();
                    break;
                case 3:
                    SortingAlgorithms.BubbleSort.Algorithm();
                    break;
                case 4:
                    SortingAlgorithms.ShellSort.Algorithm();
                    break;
                case 5:
                    SortingAlgorithms.MergeSort.Algorithm();
                    break;
                case 6:
                    SortingAlgorithms.QuickSort.Algorithm();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                    continue;
            }

            if (!AskToTryAgain())
                break;
        }
    }

    static void SearchingAlgorithmMenu()
    {
        while (true)
        {
            Console.WriteLine("Searching Algorithms");
            Console.WriteLine("1. Binary Search Algorithm");
            Console.WriteLine("2. Linear Search Algorithm");
            Console.WriteLine("3. Geri");

            int searchChoice = Convert.ToInt32(Console.ReadLine());
            switch (searchChoice)
            {
                case 1:
                    SearchAlgorithms.BinarySearch.Algorithm();
                    break;
                case 2:
                    SearchAlgorithms.LinearSearch.Algorithm();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                    continue;
            }

            if (!AskToTryAgain())
                break;
        }
    }

    static bool AskToTryAgain()
    {
        Console.WriteLine("Bu algoritmayı bir daha denemek ister misin? (0: Hayır, 1: Evet)");
        int tryAgain = Convert.ToInt32(Console.ReadLine());
        return tryAgain == 1;
    }
}

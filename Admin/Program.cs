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
                    Console.WriteLine("Basic Algoritmalar:");
                    Console.WriteLine("1. Girilen Numaraları Sıralama");
                    Console.WriteLine("2. Basamak Değeri Toplamlarını Hesaplama");
                    Console.WriteLine("3. Armstrong Sayısı Hesaplama");
                    Console.WriteLine("4. Geri");

                    int basicChoice = Convert.ToInt32(Console.ReadLine());
                    switch (basicChoice)
                    {
                        case 1:
                            int[] dizi = SortNumbers.ShowMenu();
                            SortNumbers.Algorithm(dizi);
                            break;
                        case 2:
                            int sumOfDigits = SumOfDigits.ShowMenu();
                            SumOfDigits.Algorithm(sumOfDigits);
                            break;
                        case 3:
                            int armstrong = ArmstrongNumbers.ShowMenu();
                            ArmstrongNumbers.Algorithm(armstrong);
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Intermediate Algoritmalar:");
                    Console.WriteLine("1. Palindrom Öğrenme");
                    Console.WriteLine("2. Geri");

                    int intermediateChoice = Convert.ToInt32(Console.ReadLine());
                    switch (intermediateChoice)
                    {
                        case 1:
                            IsPalindrome.IsPalindromeNumber();
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                            break;
                    }
                    break;

                case 3:
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
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("Searching Algorithms:");
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
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                            break;
                    }
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                    break;
            }
        }
    }
}

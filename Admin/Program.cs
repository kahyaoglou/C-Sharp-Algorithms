using BasicAlgorithms;
using IntermediateAlgorithms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Algoritma türünü seçiniz...");
        Console.WriteLine("Algoritmayı izlemek için breakpoint koymayı unutma :)");
        Console.WriteLine();
        Console.WriteLine("1. Basic Algorithms");
        Console.WriteLine("2. Intermediate Algorithms");
        Console.WriteLine("3. Sorting Algorithms");

        int mainChoice = Convert.ToInt32(Console.ReadLine());

        switch (mainChoice)
        {
            case 1:
                Console.WriteLine("Basic Algoritmalar:");
                Console.WriteLine("1. Girilen Numaraları Sıralama");
                Console.WriteLine("2. Basamak Değeri Toplamlarını Hesaplama");

                int basicChoice = Convert.ToInt32(Console.ReadLine());
                switch (basicChoice)
                {
                    case 1:
                        SortNumbers.Algorithm();
                        break;
                    case 2:
                        SumOfDigits.Algorithm();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                        break;
                }
                break;

            case 2:
                Console.WriteLine("Intermediate Algoritmalar:");
                Console.WriteLine("1. Palindrom Öğrenme");

                int intermediateChoice = Convert.ToInt32(Console.ReadLine());
                switch (intermediateChoice)
                {
                    case 1:
                        IsPalindrome.IsPalindromeNumber();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                        break;
                }
                break;

            case 3:
                Console.WriteLine("Sorting Algorithms:");
                Console.WriteLine("1. Bubble Sort");

                int sortChoice = Convert.ToInt32(Console.ReadLine());
                switch (sortChoice)
                {
                    case 1:
                        SortingAlgorithms.BubbleSort.Algorithm();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                        break;
                }
                break;

            default:
                Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...");
                break;
        }
    }
}


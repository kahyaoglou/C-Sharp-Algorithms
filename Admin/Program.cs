using BasicAlgorithms;
using IntermediateAlgorithms;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Algoritma türünü seçiniz...");
            Console.WriteLine("Algoritmayı izlemek için breakpoint koymayı unutma :)");
            Console.WriteLine();
            Console.WriteLine("1. Basic Algorithms");
            Console.WriteLine("2. Intermediate Algorithms");
            Console.WriteLine("3. Sorting Algorithms");
            Console.WriteLine("4. Searching Algorithms");
            Console.WriteLine("0. Çıkış");

            int mainChoice = Convert.ToInt32(Console.ReadLine());

            if (mainChoice == 1)
            {
                do
                {
                    Console.WriteLine("Basic Algoritmalar:");
                    Console.WriteLine("1.  Temel Aritmetik İşlemleri");
                    Console.WriteLine("2.  Üs Alma");
                    Console.WriteLine("3.  Girilen Numaraları Sıralama");
                    Console.WriteLine("4.  Faktöriyel Hesaplama");
                    Console.WriteLine("5.  Kombinasyon Hesaplama");
                    Console.WriteLine("6.  Asal Sayı Hesaplama");
                    Console.WriteLine("7.  EBOB - EKOK Hesaplama");
                    Console.WriteLine("8.  Dairede Alan ve Çevre Hesaplama");
                    Console.WriteLine("9.  Üçgende Alan Hesaplama");
                    Console.WriteLine("10. Basamak Değeri Hesaplama");
                    Console.WriteLine("11. Armstrong Sayıları Hesaplama");
                    Console.WriteLine("12. Mükemmel Sayıları Hesaplama");
                    Console.WriteLine("0.  Geri");

                    int basicChoice = Convert.ToInt32(Console.ReadLine());

                    if (basicChoice == 1)
                    {
                        ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
                        arithmeticOperations.ShowMenu();
                    }
                    else if (basicChoice == 2)
                    {
                        CalculateExponent.Algorithm();
                    }
                    else if (basicChoice == 3)
                    {
                        SortNumbers.Algorithm();
                    }
                    else if (basicChoice == 4)
                    {
                        CalculateFactorial.Algorithm();
                    }
                    else if (basicChoice == 5)
                    {
                        CalculateCombination.Algorithm();
                    }
                    else if (basicChoice == 6)
                    {
                        PrimeNumbers.Algorithm();
                    }
                    else if (basicChoice == 7)
                    {
                        do
                        {
                            CalculateGcdLcm calculateGcdLcm = new CalculateGcdLcm();
                            int chooseGcdLcm = calculateGcdLcm.ShowMenu();

                            if (chooseGcdLcm == 0)
                            {
                                break;
                            }
                            else if (chooseGcdLcm == 1)
                            {
                                calculateGcdLcm.GcdCalculator();
                            }
                            else if (chooseGcdLcm == 2)
                            {
                                calculateGcdLcm.LcmCalculator();
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                            }
                        } while (true);
                    }
                    else if (basicChoice == 8)
                    {
                        do
                        {
                            CircleCalculators circleCalculator = new CircleCalculators();
                            int chooseCircleOperations = circleCalculator.ShowMenu();

                            if (chooseCircleOperations == 0)
                            {
                                break;
                            }
                            else if (chooseCircleOperations == 1)
                            {
                                circleCalculator.CircumferenceCalculator();
                            }
                            else if (chooseCircleOperations == 2)
                            {
                                circleCalculator.AreaCalculator();
                            }
                            else if (chooseCircleOperations == 3)
                            {
                                circleCalculator.CentralAngleAreaCalculator();
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                            }
                        } while (true);
                    }
                    else if (basicChoice == 9)
                    {
                        do
                        {
                            TriangleCalculators triangleCalculators = new TriangleCalculators();
                            int chooseTriangleOperations = triangleCalculators.ShowMenu();
                            if (chooseTriangleOperations == 0)
                            {
                                break;
                            }
                            else if (chooseTriangleOperations == 1)
                            {
                                triangleCalculators.EquilateralTriangleArea();
                            }
                            else if (chooseTriangleOperations == 2)
                            {
                                triangleCalculators.HeightAreaCalculator();
                            }
                            else if (chooseTriangleOperations == 3)
                            {
                                triangleCalculators.HeronAreaCalculator();
                            }
                            else if (chooseTriangleOperations == 4)
                            {
                                triangleCalculators.TangentCircleAreaCalculator();
                            }
                            else if (chooseTriangleOperations == 5)
                            {
                                triangleCalculators.CircumCircleAreaCalculator();
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                            }
                        } while (true);
                    }
                    else if (basicChoice == 10)
                    {
                        SumOfDigits.Algorithm();
                    }
                    else if (basicChoice == 11)
                    {
                        ArmstrongNumbers.Algorithm();
                    }
                    else if (basicChoice == 12)
                    {
                        PerfectNumbers.Algorithm();
                    }
                    else if (basicChoice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                    }
                } while (true);
            }
            else if (mainChoice == 2)
            {
                do
                {
                    Console.WriteLine("Intermediate Algoritmalar:");
                    Console.WriteLine("1. Palindrom Öğrenme");
                    Console.WriteLine("2. Üçgen Çizme");
                    Console.WriteLine("3. Ters Üçgen Çizme");
                    Console.WriteLine("4. Elmas Çizme");
                    Console.WriteLine("0. Geri");

                    int intermediateChoice = Convert.ToInt32(Console.ReadLine());

                    if (intermediateChoice == 1)
                    {
                        IsPalindrome.IsPalindromeNumber();
                    }
                    else if (intermediateChoice == 2)
                    {
                        TriangleMaker.Algorithm();
                    }
                    else if (intermediateChoice == 3)
                    {
                        ReverseTriangleMaker.Algorithm();
                    }
                    else if (intermediateChoice == 4)
                    {
                        DiamondMaker.Algorithm();
                    }
                    else if (intermediateChoice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                    }
                } while (true);
            }
            else if (mainChoice == 3)
            {
                do
                {
                    Console.WriteLine("Sorting Algorithms:");
                    Console.WriteLine("1. Selection Sort");
                    Console.WriteLine("2. Insertion Sort");
                    Console.WriteLine("3. Bubble Sort");
                    Console.WriteLine("4. Shell Sort");
                    Console.WriteLine("5. Merge Sort");
                    Console.WriteLine("6. Quick Sort");
                    Console.WriteLine("0. Geri");

                    int sortChoice = Convert.ToInt32(Console.ReadLine());

                    if (sortChoice == 1)
                    {
                        SortingAlgorithms.SelectionSort.Algorithm();
                    }
                    else if (sortChoice == 2)
                    {
                        SortingAlgorithms.InsertionSort.Algorithm();
                    }
                    else if (sortChoice == 3)
                    {
                        SortingAlgorithms.BubbleSort.Algorithm();
                    }
                    else if (sortChoice == 4)
                    {
                        SortingAlgorithms.ShellSort.Algorithm();
                    }
                    else if (sortChoice == 5)
                    {
                        SortingAlgorithms.MergeSort.Algorithm();
                    }
                    else if (sortChoice == 6)
                    {
                        SortingAlgorithms.QuickSort.Algorithm();
                    }
                    else if (sortChoice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                    }
                } while (true);
            }
            else if (mainChoice == 4)
            {
                do
                {
                    Console.WriteLine("Searching Algorithms:");
                    Console.WriteLine("1. Binary Search Algorithm");
                    Console.WriteLine("2. Linear Search Algorithm");
                    Console.WriteLine("0. Geri");

                    int searchChoice = Convert.ToInt32(Console.ReadLine());

                    if (searchChoice == 1)
                    {
                        SearchAlgorithms.BinarySearch.Algorithm();
                    }
                    else if (searchChoice == 2)
                    {
                        SearchAlgorithms.LinearSearch.Algorithm();
                    }
                    else if (searchChoice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
                    }
                } while (true);
            }
            else if (mainChoice == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen üstteki seçeneklerden birini seçiniz...\n");
            }
        } while (true);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public static void Algorithm()
        {
            Console.Write("Kaç eleman gireceksiniz? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            for (int l = 0; l < n; l++)
            {
                Console.Write($"Eleman {l + 1}'i giriniz: ");
                A[l] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array: ");
            Display(A);

            // Sorting logic

            int left = 0; //Dizinin solundaki indexin numarası.
            int right = A.Length - 1; // Dizinin sağındaki indexin numarası.
            int mid = (left + right) / 2; //Dizinin ortasındaki indexin numarası.

            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];

            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                B[k] = A[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                B[k] = A[j];
                j++;
                k++;
            }

            for (int x = left; x <= right; x++)
            {
                A[x] = B[x];
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

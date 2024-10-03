namespace IntermediateAlgorithms
{
    public class ReverseTriangleMaker
    {
        public static void Algorithm()
        {
            Console.Write("Enter the number of digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, b;

            for (a = n; a >= 1; a--)
            {
                for (b = 1; b <= (n - a); b++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * a - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
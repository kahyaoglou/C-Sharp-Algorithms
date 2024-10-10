namespace IntermediateAlgorithms
{
    public class ReverseTriangleMaker
    {
        public static void Algorithm()
        {
            Console.Write("Üçgenin Kat Sayısını Giriniz: ");
            int katSayisi = Convert.ToInt32(Console.ReadLine());
            int a, b;

            for (a = katSayisi; a >= 1; a--)
            {
                for (b = 1; b <= (katSayisi - a); b++)
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
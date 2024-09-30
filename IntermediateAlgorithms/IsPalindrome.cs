namespace IntermediateAlgorithms
{
    public class IsPalindrome
    {
        public static void IsPalindromeNumber()
        {
            Console.Write("Lütfen sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number, lastNumber, reverseNumber = 0;

            while (temp != 0)
            {
                lastNumber = temp % 10;
                reverseNumber = (reverseNumber * 10) + lastNumber;
                temp = temp / 10;
            }

            if (number == reverseNumber)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}

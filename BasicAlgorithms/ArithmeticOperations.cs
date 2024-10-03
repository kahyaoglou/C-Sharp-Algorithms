using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class ArithmeticOperations
    {
        private double toplam, fark, carpim, bolum, firstNum, secondNum;

        public int ShowMenu()
        {
            Console.WriteLine("\n1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.WriteLine("0- Geri");
            Console.Write("Yapılacak Aritmetik İşlemi Seçiniz: ");
            return int.Parse(Console.ReadLine());
        }

        public void SetFirstAndSecondNum()
        {
            Console.Write("\nLütfen İlk Sayıyı Giriniz: ");
            this.firstNum = double.Parse(Console.ReadLine());
            Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            this.secondNum = double.Parse(Console.ReadLine());
        }

        public void EmptyFirstAndSecondNum()
        {
            this.firstNum = 0;
            this.secondNum = 0;
        }

        public void Sum()
        {
            SetFirstAndSecondNum();
            toplam = firstNum + secondNum;
            Console.WriteLine("Sonuç: " + toplam + "\n");
            EmptyFirstAndSecondNum();
        }

        public void Minus()
        {
            SetFirstAndSecondNum();
            fark = firstNum - secondNum;
            Console.WriteLine("Sonuç: " + fark + "\n");
            EmptyFirstAndSecondNum();
        }

        public void Times()
        {
            SetFirstAndSecondNum();
            carpim = firstNum * secondNum;
            Console.WriteLine("Sonuç: " + carpim + "\n");
            EmptyFirstAndSecondNum();
        }

        public void Divider()
        {
            SetFirstAndSecondNum();
            if (firstNum == 0 && secondNum == 0)
            {
                Console.WriteLine("\nSonuç: 0/0 belirsizliği!");
                Console.WriteLine("Bölen ve Bölünen '0' olmamalıdır.\n");
            }
            else if (secondNum == 0)
            {
                Console.WriteLine("\nSonuç: Tanımsız!");
                Console.WriteLine("Bölen '0' olmamalıdır.\n");
            }
            else
            {
                bolum = firstNum / secondNum;
                Console.WriteLine("Sonuç: " + bolum + "\n");
            }
            EmptyFirstAndSecondNum();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class TriangleCalculators
    {
        private double area;
        private int u, r, height, side1, side2, side3;

        public int ShowMenu()
        {
            Console.WriteLine("\n1- Eşkenar Üçgenin Alanı");
            Console.WriteLine("2- Bir Kenarı ve Bu Kenarın Yükseklik Ölçüsü Bilinen Üçgenin Alanı");
            Console.WriteLine("3- Üç Kenarının Uzunluğu Bilinen Üçgenin Alanı");
            Console.WriteLine("4- İç Teğet Çemberinin Yarıçapı ve Çevresinin Uzunluğu Bilinen Üçgenin Alanı");
            Console.WriteLine("5- Çevrel Çemberinin Yarıçapının Uzunluğu Bilinen Üçgenin Alanı");
            Console.WriteLine("0- Geri");
            Console.Write("Yapılacak İşlemi Seçiniz: ");
            return int.Parse(Console.ReadLine());
        }

        public void EquilateralTriangleArea()
        {
            Console.Write("\nBir Kenarının Uzunluğunu Giriniz: ");
            side1 = int.Parse(Console.ReadLine());

            if (side1 > 0)
            {
                area = (side1 * side1 * Math.Sqrt(3)) / 4;
                Console.WriteLine("Alan = " + area + "\n");
            }
            else
            {
                Console.WriteLine("Kenar Uzunluğu 0 veya 0'dan Küçük Olamaz!\n");
            }
        }

        public void HeightAreaCalculator()
        {
            Console.Write("\nBir Kenarının Uzunluğunu Giriniz: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("Bu Kenara Ait Yüksekliği Giriniz: ");
            height = int.Parse(Console.ReadLine());

            if (side1 > 0 && height > 0)
            {
                area = (side1 * height) / 2;
                Console.WriteLine("Alan = " + area + "\n");
            }
            else
            {
                Console.WriteLine("Kenar Uzunluğu veya Yükseklik, 0 veya 0'dan Küçük Olamaz!\n");
            }
        }

        public void HeronAreaCalculator()
        {
            Console.Write("\nİlk Kenarın Uzunluğunu Giriniz: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Kenarın Uzunluğunu Giriniz: ");
            side2 = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü Kenarın Uzunluğunu Giriniz: ");
            side3 = int.Parse(Console.ReadLine());

            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                u = (side1 + side2 + side3) / 2;
                area = Math.Sqrt(u * (u - side1) * (u - side2) * (u - side3));
                Console.WriteLine("Alan: " + area + "\n");
            }
            else
            {
                Console.WriteLine("Kenar Uzunluğu 0 veya 0'dan Küçük Olamaz!\n");
            }
        }

        public void TangentCircleAreaCalculator()
        {
            Console.Write("\nİlk Kenarın Uzunluğunu Giriniz: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Kenarın Uzunluğunu Giriniz: ");
            side2 = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü Kenarın Uzunluğunu Giriniz: ");
            side3 = int.Parse(Console.ReadLine());
            Console.Write("İç Teğet Çemberi Yarı Çapını Giriniz: ");
            r = int.Parse(Console.ReadLine());

            if (side1 > 0 && side2 > 0 && side3 > 0 && r > 0)
            {
                u = (side1 + side2 + side3) / 2;
                area = u * r;
                Console.WriteLine("Alan = " + area + "\n");
            }
            else
            {
                Console.WriteLine("Kenar Uzunluğu veya Yarı Çap, 0 veya 0'dan Küçük Olamaz!\n");
            }
        }

        public void CircumCircleAreaCalculator()
        {
            Console.Write("\nİlk Kenarın Uzunluğunu Giriniz: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Kenarın Uzunluğunu Giriniz: ");
            side2 = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü Kenarın Uzunluğunu Giriniz: ");
            side3 = int.Parse(Console.ReadLine());
            Console.Write("Çevrel Çemberin Yarıçapını Giriniz: ");
            r = int.Parse(Console.ReadLine());

            if (side1 > 0 && side2 > 0 && side3 > 0 && r > 0)
            {
                area = (side1 * side2 * side3) / (4 * r);
                Console.WriteLine("Alan = " + area + "\n");
            }
            else
            {
                Console.WriteLine("Kenar Uzunluğu veya Yarı Çap, 0 veya 0'dan Küçük Olamaz!\n");
            }
        }
    }
}

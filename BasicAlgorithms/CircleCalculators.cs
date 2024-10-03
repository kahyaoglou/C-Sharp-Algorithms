using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class CircleCalculators
    {
        double alan, cevre, aciAlan;
        int r, a;
        const double pi = 3.14;

        public int ShowMenu()
        {
            Console.WriteLine("\n- Daire Çevre(1)");
            Console.WriteLine("- Daire Alan(2)");
            Console.WriteLine("- Merkez Açılı Dairede Alan(3)");
            Console.WriteLine("- Geri(0)");
            Console.Write("Yapılacak İşlemi Seçiniz: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CircumferenceCalculator()
        {
            Console.Write("\nDairenin Yarıçapını Giriniz: ");
            r = Convert.ToInt32(Console.ReadLine());
            cevre = 2 * pi * r;
            Console.WriteLine("Çevre: " + cevre + "\n");
        }

        public void AreaCalculator()
        {
            Console.Write("\nDairenin Yarıçapını Giriniz: ");
            r = Convert.ToInt32(Console.ReadLine());
            alan = pi * r * r;
            Console.WriteLine("Alan: " + alan + "\n");
        }

        public void CentralAngleAreaCalculator()
        {
            Console.Write("\nDairenin Yarıçapını Giriniz: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merkez Açı Ölçüsünü Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && a <= 360)
            {
                aciAlan = (pi * (r * r) * a) / 360;
                Console.WriteLine("Merkez Açılı Alan: " + aciAlan + "\n");
            }
            else
            {
                Console.WriteLine("Merkez açı 0 ile 360 derece arasında olmalıdır! \n");
            }
        }

        public static void Main(string[] args)
        {
            CircleCalculators calculator = new CircleCalculators();
            int choice;

            do
            {
                choice = calculator.ShowMenu();

                switch (choice)
                {
                    case 1:
                        calculator.CircumferenceCalculator();
                        break;
                    case 2:
                        calculator.AreaCalculator();
                        break;
                    case 3:
                        calculator.CentralAngleAreaCalculator();
                        break;
                    case 0:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            } while (choice != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class ArithmeticOperations
    {
        public static void Algorithm(string ifade)
        {
            char[] operatorler = { '+', '-', '*', '/' };
            foreach (char op in operatorler)
            {
                if (ifade.Contains(op))
                {
                    string[] sayilar = ifade.Split(op);

                    if (sayilar.Length == 2 &&
                        double.TryParse(sayilar[0].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double sayi1) &&
                        double.TryParse(sayilar[1].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double sayi2))
                    {
                        double sonuc = op switch
                        {
                            '+' => sayi1 + sayi2,
                            '-' => sayi1 - sayi2,
                            '*' => sayi1 * sayi2,
                            '/' => sayi2 != 0 ? sayi1 / sayi2 : throw new DivideByZeroException("Sıfıra bölme hatası."),
                            _ => throw new InvalidOperationException("Geçersiz işlem.")
                        };

                        Console.WriteLine($"Sonuç: {sonuc}");
                    }
                }
            }
        }
    }
}

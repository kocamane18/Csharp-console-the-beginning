using System;

namespace Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, numara;
            double s1, s2, p, ort;
            Console.Write("Adınız:");
            ad = Console.ReadLine();
            Console.Write("Numaranız:");
            numara = Console.ReadLine();
            Console.WriteLine();

            Console.Write("1. sınav notunuz:");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sınav notunuz:");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje notunuz:");
            p = Convert.ToDouble(Console.ReadLine());

            ort = (s1 + s2 + p) / 3;
            Console.WriteLine();
            Console.Write("Ortalanız:"+ort);
            Console.WriteLine();  // Virgülden sonrasını virgül ile ayırıyoruz. (:
        }
    }
}

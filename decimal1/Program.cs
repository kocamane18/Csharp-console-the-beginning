using System;

namespace decimal1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal urun1, urun2, toplam;
            int s1, s2;
            urun1 = 14.85m;
            urun2 = 7.45m;
            Console.Write("1. ürünün satış miktarınız girin:");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. ürünün satış miktarınız girin:");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = urun1 * s1 + urun2 * s2;
            Console.WriteLine("Borcunuz:" + toplam);
        }
    }
}

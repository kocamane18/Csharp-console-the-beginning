using System;

namespace Metodlar
{
    class Program
    {
        private static void deneme()
        {
            Console.WriteLine("Enver Kocaman");
            Console.WriteLine("KEAIHL");
        }
        private static void yazdir(string str1)
        {
            Console.WriteLine("Senin adin Mustafa {0} olsun.",str1);
        }

        private static int topla(int s1,int s2)
        {
            return s1 + s2;
        }
        static void Main(string[] args)
        {
            deneme();
            Console.WriteLine();

            Console.Write("Bir isim giriniz:");
            string isim;
            isim = Console.ReadLine();
            yazdir(isim);
            Console.WriteLine();

            Console.WriteLine(topla(6, 7));
        }
    }
}

using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("Bir mevsim giriniz:");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "ilkbahar":
                    Console.WriteLine("Mart  Nisan  Mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("Haziran  Temmuz  Ağustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Eylül  Ekim  Kasım");
                    break;
                case "kış":
                    Console.WriteLine("Aralık  Ocak  Şubat");
                    break;
                default:
                    Console.WriteLine("Hatalı mevsim girişi...");
                    break;
            }
        }
    }
}

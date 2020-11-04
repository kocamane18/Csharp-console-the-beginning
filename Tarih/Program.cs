using System;

namespace Tarih
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nokta = DateTime.Now;
            Console.WriteLine(nokta + "\n");

            int gun = nokta.Day;
            int ay = nokta.Month;
            int yil = nokta.Year;
            DayOfWeek gunAdi = nokta.DayOfWeek;
            Console.WriteLine(nokta.Day);
            Console.WriteLine(nokta.Month);
            Console.WriteLine(nokta.Year);
            Console.WriteLine(nokta.DayOfWeek + "\n");
            
            Console.WriteLine("Kisa tarih: {0:d}", nokta);
            Console.WriteLine("Uzun tarih: {0:D}", nokta);
            Console.WriteLine();

           
        }
    }
}

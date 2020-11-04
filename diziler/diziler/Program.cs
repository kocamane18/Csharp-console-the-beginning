using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Dizinin " + (i+1) + ". elamanını girin:");
                dizi[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + dizi[i]);
            }
        }
    }
}

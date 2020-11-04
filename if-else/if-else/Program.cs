using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string cevap;
            Console.WriteLine("Türkiye'nin başkenti neresidir?");
            cevap = Console.ReadLine();
            Console.WriteLine();

            if (cevap == "Ankara")
            {
                Console.WriteLine("Doğru cevap.");
            }
            if (cevap == "İstanbul")
            {
                Console.WriteLine("<3 <3 <3");
            }
            else
            {
                Console.WriteLine("Yolun sonu...");
            }
        }
    }
}

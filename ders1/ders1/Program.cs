using System;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "12b.5";
            Console.Write(a);
            Console.WriteLine("Hello World!");

            string isim;
            Console.Write("İsim girin:");
            isim = Console.ReadLine();
            Console.WriteLine("Hosgeldin " + isim + ".");
            Console.WriteLine("Eyvallah {0} {1}", isim, a);

        }
    }
}

using System;

namespace Array_komutları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 7, 2, 11, 0, 6 };
            Array.ForEach(dizi, a => Console.Write(a+"  "));
            Console.WriteLine();

            Array.Sort(dizi);
            foreach(int a in dizi)
            {
                Console.Write(a+"  ");
            }
            Console.WriteLine();
            Console.WriteLine(dizi[2]);

            Array.Reverse(dizi);
            Array.ForEach(dizi, a => Console.Write(a + "  "));
        }
    }
}

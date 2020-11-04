using System;

namespace ders14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 20, 86, 1, 34, 98, 22, 45 };         
            foreach (int a in dizi)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            int enbuyuk = dizi[0];
            for(int i = 1; i < 7; i++)
            {
                if (enbuyuk < dizi[i])
                {
                    enbuyuk = dizi[i];
                }
            }
            Console.WriteLine(enbuyuk);
        }
    }
}

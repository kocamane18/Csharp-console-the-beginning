using System;
using System.Security.Cryptography;

namespace Classlar
{
    class Program
    {
        int carp(int s1,int s2)
        {
            return s1 * s2;
        }
        static void Main(string[] args)
        {
            Program ggg = new Program();
            Console.WriteLine(ggg.carp(4, 5));

            Class1 baskan = new Class1();
            baskan.isim = "Melike";
            baskan.soyisim = "Kaya";
            baskan.yas = 14;
        }
    }
}

using System;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            char[] harf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n' };
            int x1;
            x1 = rastgele.Next(0, harf.Length);
            Console.WriteLine(harf[x1]);
            
        }
    }
}

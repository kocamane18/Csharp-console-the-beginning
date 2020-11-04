using System;

namespace Yildizlarla_sekil_cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 4; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");                   
                }
                for(int k = 5; k > i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for(int i = 2; i < 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 5; k > i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

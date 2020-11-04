using System;
using System.Numerics;

namespace Çok_boyutlu_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2,3];
            matrix[0, 0] = 10;
            matrix[0, 1] = 20;
            matrix[0, 2] = 30;
            matrix[1, 0] = 40;
            matrix[1, 1] = 50;
            matrix[1, 2] = 60;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

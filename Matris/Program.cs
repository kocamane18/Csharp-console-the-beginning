using System;

namespace Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("Satir sayisini girin:");
            satir = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sutun sayisini girin:");
            sutun = Convert.ToInt16(Console.ReadLine());
            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < sutun; j++)
                {
                    Console.Write("Matrisin {0} x {1}. degeri:", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            
            for(int i = 0; i < satir; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < sutun; j++)
                {
                    Console.Write(matris[i, j] + "  ");
                }
            }
        }
    }
}

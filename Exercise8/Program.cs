using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {//15×15 lik dizi içine rasgele “S” ve “O” harfleri atayan ve ekranda gösteren

            char[,] arr = new char[15, 15];
            string pool = "SO";
            int nIndex;
            Random accidental = new Random();

            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    nIndex = accidental.Next(0, 2);
                    arr[i, j] = pool[nIndex];
                }
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(" " +arr[i, j]);
                }
            }



            Console.Read();
        }
    }
}

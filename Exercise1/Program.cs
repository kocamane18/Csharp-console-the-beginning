using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        { // Girilen sayinin asal olup olmadigini bulan ve sayidan sonraki 5 asal sayiyi yazdiran program

            int counter = 0, n, nPrime = 0;

            Console.Write("Enter a number:");

            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i<n; i++)
            {
                if (n % i == 0)
                    counter++;
            }

            if (counter < 1)
                Console.WriteLine("The number you entered is primal.");
            else
                Console.WriteLine("The number you entered is not primal.");

            for(int j = n+1; ; j++)
            {
                counter = 0;

                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                        counter++;
                }

                if (counter < 1)
                {
                    Console.WriteLine(j);
                    nPrime++;
                }

                if (nPrime == 5)
                    break;
            }




            Console.Read();
        }
    }
}

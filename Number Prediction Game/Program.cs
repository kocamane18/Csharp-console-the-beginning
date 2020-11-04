using System;
using System.Diagnostics.Tracing;

namespace Number_Prediction_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number between 1-999.");

            int answer, n1 = 0, counter = 0;
            Random rastgele = new Random();
            answer = rastgele.Next(1, 1000);

            Console.WriteLine();

            while(n1 != answer)
            {
                Console.Write("Guess the number:");
                n1 = Convert.ToInt16(Console.ReadLine());

                if (n1 < answer)
                    Console.WriteLine("Go up.");
                else if (n1 > answer)
                    Console.WriteLine("Go down.");

                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("The number of tryings:{0}", counter);


        }
    }
}

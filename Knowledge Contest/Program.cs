using System;

namespace Knowledge_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCorrect = 0, point = 0;
            char answer;

            Console.WriteLine("**********Knowledge Contest**********\n");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter characters as upper case.");
            Console.WriteLine("Each question is 20 points.");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("1- How many legs a spider has?\na)4\nb)5\nc)6");
            Console.Write("The answer:");

            answer = Convert.ToChar(Console.ReadLine());

            if(answer == 'C')
            {
                nCorrect++;
                point += 20;
            }

            Console.WriteLine();
            Console.WriteLine("2- Where is the capital of Turkey?\na)Ankara\nb)Istanbul\nc)Mus");
            Console.Write("The answer:");

            answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'A')
            {
                nCorrect++;
                point += 20;
            }

            Console.WriteLine();
            Console.WriteLine("3- Which of the numbers below is not even?\na)4\nb)3\nc)12");
            Console.Write("The answer:");

            answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'B')
            {
                nCorrect++;
                point += 20;
            }

            Console.WriteLine();
            Console.WriteLine("4- What year the first man go to the moon?\na)2000\nb)1893\nc)1969");
            Console.Write("The answer:");

            answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'C')
            {
                nCorrect++;
                point += 20;
            }
            Console.WriteLine();

            Console.WriteLine("The number of correct answers:{0}", nCorrect);
            Console.WriteLine("The number of wrong answers:{0}", 4-nCorrect);
            Console.WriteLine("The points you have:{0}", point);
        }
    }
}

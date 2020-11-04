using System;

namespace ref_komutu
{
    class Program
    {
        static void up(int s)
        {
            s++;
        }
        static void realUp(ref int s)
        {
            s++;
        }
/* The ref keyword in C# is used for passing or returning references of values to or from
Methods. Basically, it means that any change made to a value that is passed by reference will
reflect this change since you are modifying the value at the address and not just the value. */
        static void realUp2(out int s)
        {
            s = 5;
            s++;
        }
        static void Main(string[] args)
        {
            int a = 10;
            up(a);
            Console.WriteLine(a + "\n");

            realUp(ref a);
            Console.WriteLine(a + "\n");

            int b;
            realUp2(out b);
            Console.WriteLine(b);
            realUp2(out b);
            Console.WriteLine(b);
        }
    }
}

using System;

namespace Classlar
{
    class human
    {
        public virtual /* bu fonksiyonun iptal edilebilir */ void salute /* selamlamak */()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Title = "Classes + Capsules";
            Console.WriteLine("Hello fella!");
        }
    }
    class Turk : human
    {
        public override void salute()
        {
            Console.WriteLine("Esselamu aleykum");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Turk erdem = new Turk();
            erdem.salute();
        }
    }
}

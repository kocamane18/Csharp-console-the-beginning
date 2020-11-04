using System;

namespace Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Estate estate1 = new Estate();
            estate1.gCountry = "Istanbul";
            estate1.gStreet = "Pendik";
            estate1.gNumRooms = 6;
            estate1.gArea = 62.8;

            Console.WriteLine(estate1.gCountry);
            Console.WriteLine(estate1.gStreet);
            Console.WriteLine(estate1.gNumRooms);
            Console.WriteLine(estate1.gArea);

            
        }
    }
    
}

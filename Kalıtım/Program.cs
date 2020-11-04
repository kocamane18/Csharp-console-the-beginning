using System;

namespace Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            School school1 = new School();
            school1.gName = "Elmorten Highschool";
            school1.gOpeningYear = 1978;
            school1.gAge = 61;
            school1.gCourse = "Engineering Math.";

            Console.WriteLine(school1.gName);
            Console.WriteLine(school1.gOpeningYear);
            Console.WriteLine(school1.gAge);
            Console.WriteLine(school1.gCourse);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {//Dik kenar uzunlukları verilen dik üçgende hipotenüs hesaplayan

            int e1, e2;

            e1 = Convert.ToInt32(Console.ReadLine());
            e2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(e1 * e1 + e2 * e2));

            Console.Read();
        }
    }
}

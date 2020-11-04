using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen string ifadede boşluğa kadar olan kısmı yazdırıp karakter sayısını bulma
            // https://www.yazilimkodlama.com/programlama/c-console-ornekleri/

            string metin = Console.ReadLine();
            
            
            int no = metin.IndexOf(' ');

            Console.WriteLine(no);

            Console.WriteLine(metin.Substring(0, no));


            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen cumlenin kelime sayisini bulma
            // https://www.yazilimkodlama.com/programlama/c-console-ornekleri/

            Console.Write("Enter a sentence: ");

            string sentence = Console.ReadLine();
            string[] arr = sentence.Split(' ');

            Console.WriteLine(arr.Length);
            

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {//  Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide, en uzun metni, 
     //karakter sayısını ve index numarasını yazdıran program 
     // https://www.yazilimkodlama.com/programlama/c-console-ornekleri/

        static void Main(string[] args)
        {
            string[] arr = new string[10];

            int indexNo = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the {0}. element of the array:", i+1);
                arr[i] = Console.ReadLine();
            }

            for(int j = 1; j < 10; j++)
            {
                if (arr[0].Length < arr[j].Length)
                {
                    arr[0] = arr[j];
                    indexNo = j;
                }
            }

            Console.WriteLine();
            Console.WriteLine(arr[0]);
            Console.WriteLine("The number of characters the text has: {0}", arr[0].Length);
            Console.WriteLine("The number of the index: {0}", indexNo);


            Console.Read();
        }
    }
}

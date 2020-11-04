using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Verilen bir string metnin içerisinde harf yada karakterlerin her birinden kaç adet olduğunu bulan program: */
            // https://www.yazilimkodlama.com/programlama/c-console-ornekleri/


            String metin = "www.yazilimkodlama.com";
            metin = metin.ToLower();
            String karakterler = "0123456789abcdefghijklmnopqrstuvwxyz.?,;";

            int[] count = new int[karakterler.Length];

            for (int i = 0; i < metin.Length; i++)
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]);
                }
            }



            Console.Read();
        }
    }
}

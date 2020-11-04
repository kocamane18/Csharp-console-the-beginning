using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {//10 karakterli rasgele karakterlerden oluşan metin oluşturan
            //https://www.yazilimkodlama.com/programlama/c-console-ornekleri/

            Random rastgele = new Random();

            string harfler = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string uret = "";

            for (int i = 0; i < 10; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }

            Console.WriteLine(uret);


            Console.Read();
        }
    }
}

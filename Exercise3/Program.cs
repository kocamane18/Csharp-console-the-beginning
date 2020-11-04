using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        { /* Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan,
      sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç
      tanesinin bu ortalamadan büyük ve küçük olduğunu sayan program */

            Random rdm = new Random();

            int[] arr = new int[20];
            int sum = 0, bigger = 0, lower = 0;
            
            for(int i = 0; i <= 19; i++)
            {
                arr[i] = rdm.Next(0, 100);
                sum += arr[i];
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();

            for(int i = 0; i <= 19; i++)
            {
                if (arr[i] > (double)sum / 20)
                    bigger++;
                else if (arr[i] < (double)sum / 20)
                    lower++;
            }

            Console.WriteLine("There are {0} numbers bigger than the avarage.", bigger);
            Console.WriteLine("There are {0} numbers lower than the avarage.", lower);




            Console.Read();
        }
    }
}

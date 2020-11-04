using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            Random goals = new Random();

            int f = 0, t = 0, b = 0, g = 0;
            int gFb, gTs, gBjk, gGs;

            Console.WriteLine("*****Conclusions of the Matches*****\n");
            Console.ReadLine();

            gFb = goals.Next(0, 6);
            gTs = goals.Next(0, 6);
            gBjk = goals.Next(0, 6);
            gGs = goals.Next(0, 6);

            if (gFb > gTs)
                f += 3;
            if (gTs > gFb)
                t += 3;
            if (gFb == gTs)
            {
                f++;
                t++;
            }

            if (gBjk > gGs)
                b += 3;
            if (gBjk < gGs)
                g += 3;
            if (gBjk == gGs)
            {
                b++;
                g++;
            }

            Console.WriteLine("1st Week Conclusions");
            Console.WriteLine("--------------------");
            Console.WriteLine("Fenerbahce {0} - {1} Trabzonspor", gFb, gTs);
            Console.WriteLine("Besiktas {0} - {1} Galatasaray", gBjk, gGs);
            Console.ReadLine();

            gFb = goals.Next(0, 6);
            gTs = goals.Next(0, 6);
            gBjk = goals.Next(0, 6);
            gGs = goals.Next(0, 6);

            if (gFb > gBjk)
                f += 3;
            if (gBjk > gFb)
                b += 3;
            if (gFb == gBjk)
            {
                f++;
                b++;
            }

            if (gGs > gTs)
                g += 3;
            if (gTs > gGs)
                t += 3;
            if (gGs == gTs)
            {
                g++;
                t++;
            }

            Console.WriteLine("2nd Week Conclusions");
            Console.WriteLine("--------------------");
            Console.WriteLine("Fenerbahce {0} - {1} Besiktas", gFb, gBjk);
            Console.WriteLine("Galatasaray {0} - {1} Trabzonspor", gGs, gTs);
            Console.ReadLine();

            gFb = goals.Next(0, 6);
            gTs = goals.Next(0, 6);
            gBjk = goals.Next(0, 6);
            gGs = goals.Next(0, 6);

            if (gFb > gGs)
                f += 3;
            if (gGs > gFb)
                g += 3;
            if (gFb == gGs)
            {
                f++;
                g++;
            }

            if (gBjk > gTs)
                b += 3;
            if (gTs > gBjk)
                t += 3;
            if (gBjk == gTs)
            {
                b++;
                t++;
            }

            Console.WriteLine("3rd Week Conclusions");
            Console.WriteLine("--------------------");
            Console.WriteLine("Fenerbahce {0} - {1} Galatasaray", gFb, gGs);
            Console.WriteLine("Besiktas {0} - {1} Trabzonspor\n", gBjk, gTs);
            Console.ReadLine();
            Console.WriteLine("League has come to an end.");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Trabzonspor:{0}", t);
            Console.WriteLine("Galatasaray:{0}", g);
            Console.WriteLine("Besiktas:{0}", b);
            Console.WriteLine("Fenerbahce:{0}", f);

            SoundPlayer anthem = new SoundPlayer();
            string path;

            if(t > g && t > b && t > f)
            {
                path = "C:\\Users\\CASPER\\Desktop\\ts.wav";
                anthem.SoundLocation = path;
                anthem.Play();
            }
            else if (g > t && g > b && g > f)
            {
                path = "C:\\Users\\CASPER\\Desktop\\gs.wav";
                anthem.SoundLocation = path;
                anthem.Play();
            }
            else if (b > g && b > t && b > f)
            {
                path = "C:\\Users\\CASPER\\Desktop\\bjk.wav";
                anthem.SoundLocation = path;
                anthem.Play();
            }
            else if (f > g && f > b && f > t)
            {
                path = "C:\\Users\\CASPER\\Desktop\\fb.wav";
                anthem.SoundLocation = path;
                anthem.Play();
            }
            else
            {
                path = "C:\\Users\\CASPER\\Desktop\\Dunyayamesaj.wav";
                anthem.SoundLocation = path;
                anthem.Play();
            }



            Console.Read();
        }
    }
}

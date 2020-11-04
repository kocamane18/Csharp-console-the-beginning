using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Playing_Music
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer music = new SoundPlayer();
            string access = "C:\\Users\\CASPER\\Desktop\\Welcome to the Show.wav"; // parantezden önce @ da koyabilirdik.
            music.SoundLocation = access;
            music.Play();

            Console.Read();
        }
    }
}

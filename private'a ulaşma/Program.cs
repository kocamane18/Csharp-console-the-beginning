using System;

namespace private_a_ulaşma
{
    class Program
    {
        static void Main(string[] args)
        {
            pekala bsknYancisi = new pekala();
            bsknYancisi.ADİ = "Suleyman";
            bsknYancisi.Yasi = 14;

            Console.WriteLine(bsknYancisi.ADİ);
            Console.WriteLine(bsknYancisi.Yasi);
            
        }
    }
}

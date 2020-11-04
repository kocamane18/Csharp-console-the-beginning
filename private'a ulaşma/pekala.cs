using System;
using System.Collections.Generic;
using System.Text;

namespace private_a_ulaşma
{
    class pekala
    {
        private string isim;
        private int yas;


        public string ADİ
        {
            get { return isim; }
            set { isim = value; }
        }

        public int Yasi
        {
            get { return yas; }
            set
            {
                if (yas < 18) { yas = 18; }
                else { yas = value; }
            }
        }
    }
}
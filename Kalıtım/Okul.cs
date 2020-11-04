using System;
using System.Collections.Generic;
using System.Text;

namespace Kalıtım
{
    class School:Teacher
    {
        private string name;
        private int openingYear;

        public string gName
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }

        public int gOpeningYear
        {
            get { return openingYear; }
            set { openingYear = Math.Abs(value); }
        }


    }
}

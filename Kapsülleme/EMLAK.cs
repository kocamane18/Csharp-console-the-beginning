using System;
using System.Collections.Generic;
using System.Text;

namespace Kapsülleme
{
    class Estate
    {
        private string country;
        private string street;
        private int numRooms;
        private double area;


        public string gCountry
        {
            get { return country; }
            set { country = value.ToUpper(); }
        }

        public string gStreet
        {
            get { return street; }
            set { street = value.ToLower(); }
        }

        public int gNumRooms
        {
            get { return numRooms; }
            set { numRooms = Math.Abs(value); }
        }

        public double gArea
        {
            get { return area; }
            set { area = Math.Abs(value); }
        }
    }
}

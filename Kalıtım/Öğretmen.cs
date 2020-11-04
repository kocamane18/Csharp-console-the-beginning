using System;
using System.Collections.Generic;
using System.Text;

namespace Kalıtım
{
    class Teacher
    {
        private int age;
        private string course;

        public int gAge
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }

        public string gCourse
        {
            get { return course; }
            set { course = value.ToLower(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac
{
    class Person
    {
        private string cName;
        private int nAge;
        private char cGender;


        public int Age
        {
            get
            {
                return nAge;
            }
            set
            {
                if (value >= 0)
                {
                    nAge = value;
                }
            }
        }

        public void Say()
        {

        }
    }
}

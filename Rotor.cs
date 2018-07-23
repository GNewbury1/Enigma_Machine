using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Project
{
    class Rotor
    {
        private char startpoint;
        private bool isLast;

        public Rotor(bool isLast, char startpoint)
        {
            this.startpoint = startpoint;
            this.isLast = isLast;
        }

        public char initialise()
        {
            return startpoint;
        }

        public char nextChar(char currentChar, bool encoding)
        {
            int ascii = (int)currentChar;
            if (encoding)
            {
                ascii += 1;
            }
            
            if (ascii > 90)
            {
                ascii = 65;
            }

            if (ascii < 65)
            {
                ascii = 90;
            }
            return (char)ascii;
        }


    }
}

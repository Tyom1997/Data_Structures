using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BinaryInt
    {
        public int Find(int number)
        {
            if (number == 0)
                return 0;
            else
                return (number % 2 + 10*Find(number / 2));
        }
    }
}

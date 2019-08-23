using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Treangle
    {
        public void Draw(int a, int spaces)
        {
            if (a < 0)   
                return;
            Draw(a - 1, spaces + 1);
            for (int i = 0; i < spaces; i++) 
                Console.Write(" ");
            for (int i = 0; i < a; i++)
                Console.Write("* ");
            Console.Write("\n");
        }
    }
}

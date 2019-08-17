using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Triangle
    {
        int i = 1;
        int k = 5;
        int h = 1;
        public void DrawTreangle()
        {
            while (i <= 5)
            {
                Console.WriteLine("");
                while (k > i)
                {
                    Console.Write(" ");
                    k--;
                }
                while (h <= i)
                {
                    Console.Write("**");
                    h++;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}

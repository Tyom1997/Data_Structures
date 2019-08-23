using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Polindrome
    {
        List<int> list = new List<int>();
        private int val;
        public void Find(int number)
        {
            if( number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == list[list.Count - i - 1])
                {
                    val++;
                }
                else
                {
                    val= 0;
                }
            }
            if (val == list.Count)
            {
                Console.WriteLine("NUmber is polindrome");
            }
            else
            {
                Console.WriteLine("Number is not polindrome");
            }
        }

    }
}

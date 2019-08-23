using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Fibonachi
    {
        public void FibonachiIteratively(int number)
        {
            int result = 0;
            int previous = 1;
            for (int i = 0; i < number; i++)
            {
                Console.Write(result + " ");
                int temp = result;
                result = previous;
                previous = temp + previous;
            }
        }
        public int FibonachiRecursive(int num, int val = 1, int previous = 0)
        {
            if (num == 0)
                return previous;
            Console.Write(previous+" ");
            return FibonachiRecursive(num - 1, val + previous, val);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class FindElementOnce
    {
        public  int FindSingle(int[] arr)
        {
            int res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res = res ^ arr[i];
            return res;
        }
    }
}

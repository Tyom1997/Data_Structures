using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class LargeInteger
    {
        public void AddNUmberList(int number)
        {
            LinkedList<int> list = new LinkedList<int>();

            while (number > 0)
            {
                list.Addfirst(number % 10);
                number /= 10;
                list.Show();
            }

        }
    }
}

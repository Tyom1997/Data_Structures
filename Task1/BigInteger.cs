using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class BigInteger
    {
        LinkedList<int> list = new LinkedList<int>();
        private BigInteger()
        {
            
        }
        public BigInteger(int number)
        {
            while (number > 0)
            {
                list.Addfirst(number % 10);
                number /= 10;
                list.Reverse();
            }
        }
        public BigInteger Sum(BigInteger num)
        {
            BigInteger c = new BigInteger();
            for (int i = 0; i < list.Count; i++)
            {
                int bonus = 0;
                int count=0;
                if (list.Count >= num.list.Count)
                    count = num.list.Count;
                else
                    count = list.Count;
                for (int j = 0; j < count; j++)
                {
                    var s = list.First() + num.list.First() + bonus;
                    list.Addlast(list.RemoveFirst());
                    num.list.Addlast(num.list.RemoveFirst());
                    bonus = s / 10;
                    s = s % 10;
                    c.list.Addlast(s);
                }
                if (list.Count > num.list.Count)
                {
                    int count1 = list.Count - num.list.Count;
                    for(int j = 0; j < count1; j++)
                    {
                        var s1 = list.First()+bonus;
                        list.Addlast(list.RemoveFirst());
                        bonus = s1 / 10;
                        s1 = s1 % 10;
                        c.list.Addlast(s1);
                    }
                }
                if (list.Count < num.list.Count)
                {
                    int count1 = num.list.Count - list.Count;
                    for (int j = 0; j < count1; j++)
                    {
                        var s1 = num.list.First() + bonus;
                        num.list.Addlast(num.list.RemoveFirst());
                        bonus = s1 / 10;
                        s1 = s1 % 10;
                        c.list.Addlast(s1);
                    }
                }
                if (bonus > 0)
                    c.list.Addlast(bonus);
            }
            return c;
        }
        public void PrintBigInteger()
        {
            list.Show();
        }
    }
}

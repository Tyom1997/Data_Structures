using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Polindrome
    {
        public bool Find()
        { 
        int n,r, sum = 0, temp;
        Console.Write("Enter the Number: ");   
          n = int.Parse(Console.ReadLine());
        temp=n;      
          while(n>0)      
          {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
          }
            if (temp == sum)
                return true;

            return false;
                
        }  
    }
}

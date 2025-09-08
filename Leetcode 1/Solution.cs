using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_1
{
    internal class Solution
    {
        public static int[] GetNoZeroIntegers(int n)
        {
            int[] result = new int[2];
            Boolean found = false;
            int a = 0;
            int b = 0;
            while (found == false) 
            {
                a++;
                b = n - a;
                if ((!(a.ToString().Contains("0"))) && (!(b.ToString().Contains("0"))))
                {
                    result[0] = a;
                    result[1] = b;
                    found = true;
                }
            }
            return result;
        }
    }
}

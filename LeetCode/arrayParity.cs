using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

namespace LeetCode
{
    class arrayParity
    {
        
            public int[] SortArrayByParity(int[] A)
            {
            List<int> ans = new List<int>();
                foreach (int x in A)
            {
                if (x % 2 == 0) // even
                {
                    ans.Add(x);

                }
            }
                foreach (int y in A)
            {
                if (y % 2 != 0)
                {
                    ans.Add(y);
                }
            }
            return ans.ToArray();


            }
        
    }
}

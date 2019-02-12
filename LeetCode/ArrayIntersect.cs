using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   static class ArrayIntersect
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> intr = new List<int>();
            List<int> ans = new List<int>();

            foreach (int x in nums1)
            {
                foreach (int y in nums2)
                {
                    if (x == y)
                    {
                        intr.Add(y);
                    }
                }
            }
            if (intr.Count == 0)
            {
                int[] ans0 = { };
                return ans0;
            }
            ans.Add(intr[0]);
            foreach (int z in intr)
            {
                if (!ans.Contains(z))
                {
                    ans.Add(z);
                }

            }
            return ans.ToArray();
        }
    }
}

//HashSet. This is an optimized set collection. It helps eliminates duplicate strings or elements in an array. 
//It is a set that hashes its contents.

//class Program
//{
//    static void Main()
//    {
//        // Input array that contains three duplicate strings.
//        string[] array1 =
//        {
//            "cat",
//            "dog",
//            "cat",
//            "leopard",
//            "tiger",
//            "cat"
//        };

//        // Display the array.
//        Console.WriteLine(string.Join(",", array1));

//        // Use HashSet constructor to ensure unique strings.
//        var hash = new HashSet<string>(array1);

//        // Convert to array of strings again.
//        string[] array2 = hash.ToArray();

//        // Display the resulting array.
//        Console.WriteLine(string.Join(",", array2));
//    }
//}

/*
 ●	Given a sorted array, remove the duplicates in-place and return the new length.
Time Complexity : O(n)
Space Complexity :O(1)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No4_MoveDuplicate
    {
        public int removeZero(int[] arr)
        {
            if (arr.Length <=1) return arr.Length;
            int nonduplicate = 1;
            //sorted arr: duplicate value must be next to each element
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[nonduplicate] = arr[i];
                    nonduplicate++;
                }
            }
            return nonduplicate;
        }
    }
}

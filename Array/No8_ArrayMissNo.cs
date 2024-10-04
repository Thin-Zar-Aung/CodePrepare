/*
 * Given an array of size n with elements from 1 to n, find the missing number.
 * Time Complexity : O(n)
 * Space Complexity : O(1)
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No8_ArrayMissNo
    {
        public int missnumber(int[] arr,int n)
        {
            int arrsize = arr.Length;
            int expectSum = n * (n + 1) / 2;
            int arrsum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arrsum += arr[i];
            }
            return expectSum - arrsum;

        }

    }
}

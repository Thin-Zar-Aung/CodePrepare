/*
 * ●	Calculate the sum of all elements in the array.
 * Time Complexity : O(n)
 * Space Complexity :O(1)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No2_ArraySum
    {
        public int ArrSum(int[] arr)
        {
            if (arr.Length <= 0) return 0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}

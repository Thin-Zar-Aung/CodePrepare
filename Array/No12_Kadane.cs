/*
 * Kadane’s Algorithm
 * Find the contiguous subarray with the largest sum in an array of integers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No12_Kadane
    {
        public int getMaxSubArrSum(int[] arr)
        {
            int maxsubarray = arr[0];
            int currsubarray = arr[0];
            for (int i = 1; i < arr.Length; i++)//start from index 1
            {
                //assgin only value greater than zero
                currsubarray = Math.Max(arr[i], currsubarray + arr[i]);
                maxsubarray = Math.Max(currsubarray, maxsubarray);

            }
            return maxsubarray;
        }
        
    }
}

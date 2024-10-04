/*
 * ●	Determine if the given array is sorted in ascending order.
 * Time Complexity : O(N)
 * Space Complexity : O(1)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No3_ArraySorted
    {
        public bool checkSorted(int[] arr)
        {
           
            if (arr.Length <= 0) return true;
            //loop the array and compare
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]> arr[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}

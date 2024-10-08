/*
 * Trapping Rain Water
 * Time complexity : O(n)
 * Space complexity :O(1)
 */
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No16_TrapRain
    {
        public int getMax(int[] arr)
        {
            int res = 0;
            int left = 0;
            int right = arr.Length - 1;
            int maxleft = 0;
            int maxright = 0;
            while (left < right)
            {
                if (arr[left] <= arr[right])
                {
                    maxleft = Math.Max(arr[left], maxleft);
                    res += maxleft - arr[left];
                    left++;
                }
                else if (arr[right] <= arr[left])
                {
                    maxright = Math.Max(arr[right], maxright);
                    res += maxright - arr[right];
                    right--;

                }
            }
            return res;

        }
    }
}

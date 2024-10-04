/*
 * Given an array, find the smallest and largest numbers.
 * Time complexity:O(N)
 * Space Complexity:O(1)
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No10_SmallLargeNo
    {
        public int[] getSmallandLarge(int[] nums)
        {
            int smallnum = nums[0];
            int largenum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (smallnum >nums[i])
                {
                    smallnum = nums[i];
                    
                }
                if (largenum < nums[i])
                {
                   
                    largenum = nums[i];
                    
                }
            }
            return new int[] { smallnum, largenum };
        }
    }
}

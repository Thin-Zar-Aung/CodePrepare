/*
 * Find the number of subarrays whose sum equals a given value.
 * TimeComplexity: O(n)
 * Space:O(n)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No17_SubArraySum
    {
        public int getSubSum(int[]arr, int k)
        {
            int count = 0;
             Dictionary<int,int> map = new Dictionary<int, int>();//key:sum value:count
            map[0] = 1;//if the element and k is same value to count the res
            int presum = 0;
            for(int i = 0; i < arr.Length; i++)
            {   
                presum += arr[i];
                if (map.ContainsKey(presum - k))
                {
                    count += map[presum - k];
                }
                if (map.ContainsKey(presum))
                {
                    map[presum]++;
                }
                else map[presum] = 1;
            }
            return count;
        }
    }
}

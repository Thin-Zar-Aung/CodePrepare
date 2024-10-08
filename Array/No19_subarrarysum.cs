using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No19_subarrarysum
    {//1,1,1 k=2
        // presum +=3
        //findinmap = presum-2= 3-2=1
        //count=2;
        //map(key: value) : (0,1)(1,2)(2,1)
        public int getSubArraySum(int[] arr,int k)
        {
            int prefixsum = 0;
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1; //to count findvalue zero
            for(int i = 0; i < arr.Length; i++)
            {
                prefixsum += arr[i];
                int findvalue = prefixsum - k;
                if (map.ContainsKey(findvalue))
                {
                    count++;
                }
                if (map.ContainsKey(prefixsum))
                {
                    map[prefixsum]++;
                }
                else map[prefixsum] = 1;
                
            }
            return count;
        }
        
    }
}

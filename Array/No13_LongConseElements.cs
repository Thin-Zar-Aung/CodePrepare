/*
 * Find the length of the longest sequence of consecutive elements in an unsorted array.
 * Time Complexity:O(n)
 * Space Complexity:O(n)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No13_LongConseElements
    {
        public int getLongElement(int[] arr)
        {//{0,4,9,10,13,1,2,3}
           
            int longestarr = 0;
           
            HashSet<int> set = new HashSet<int>(arr);
            foreach(int i in set)
            {
                //check for next large value 100 and 99 check 99+1
                if (!set.Contains(i-1))
                {
                    int increment = 1;
                    int num = i;
               
                while (set.Contains(num + 1))                {
                    num++;
                    increment++;                }
                longestarr = Math.Max(increment,longestarr) ;
            }

            }
            return longestarr;

        }
    }
}

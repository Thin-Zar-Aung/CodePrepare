/*
 * Given an array, find all pairs that sum up to a specific target.
 * Time Complexity : O(N)
 * Space Complexity : O(N)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No9_ArrayFindSumPair
    {
        public List<List<int>> findPair(int[] arr, int target)
        {
            List<List<int>> res = new List<List<int>>();
            Dictionary<int, int> freqmap = new Dictionary<int, int>();//key:arr element value:count
            for (int i = 0; i < arr.Length; i++)
            {
                {
                    int subtract = target - arr[i];

                    //arr[i]and subtract same
                    if (subtract == arr[i] && freqmap.ContainsKey(subtract) && freqmap[subtract] == 1)
                    {
                        res.Add(new List<int> { arr[i], arr[i] });
                    }
                    // arr[i] and subtract different
                    else if (freqmap.ContainsKey(subtract) && !freqmap.ContainsKey(arr[i]))
                    {
                        res.Add(new List<int> { arr[i], subtract});
                    }

                    // Update the freqmapuency map
                    if (!freqmap.ContainsKey(arr[i]))
                    {
                        freqmap[arr[i]] = 1;
                    }
                    else
                    {
                        freqmap[arr[i]]++;
                    }
                }
            }
            return res;
        }




        
        
    }
}

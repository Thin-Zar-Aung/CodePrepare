/*Given two sorted arrays, merge them into a single sorted array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No14_ArrayMerger
    {
        public int[] SortMergeArray(int[] arr1, int[] arr2)
        {
            {
                
                int[] res = new int[arr1.Length + arr2.Length];
                int p1 = 0;
                int p2 = 0;
                int p3 = 0;
                while (p1 < arr1.Length && p2 < arr2.Length)
                {
                    if (arr1[p1] > arr2[p2])
                    {
                        res[p3] = arr2[p2];                       
                        p2++;
                        p3++;
                    }
                    else if (arr1[p1] < arr2[p2])
                    {
                        res[p3] = arr1[p1];
                        p1++;                        
                        p3++;
                    }
                }
                while (p1 < arr1.Length)
                {
                    res[p3] = arr1[p1];
                    p1++;
                    p3++;
                }
                while (p2 < arr2.Length)
                {
                    res[p3] = arr2[p2];
                    p2++;
                    p3++;
                }
                return res;
            }
        }
    }
}
            
        


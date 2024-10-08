/*
 ●	Given an array, move all zeros to the end while maintaining the relative order of non-zero elements. 
Time Complexity : O(n)
Space Complexity : O(1)
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No5_MoveZero
    { 
     public int[] MoveZero(int[] arr)
        {//{0,1,0,2,0}
            if(arr.Length<=1) return arr;
            int nonzeroindex = 0;
            //Loop the array
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[nonzeroindex];
                    arr[nonzeroindex] = temp;
                    nonzeroindex++;
                }
            }
            return arr;

        }
    }
}

/*
 Write a function to reverse the given array. 
Time Complexity : O(n) 
Space Complexity : O(1)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No1_ArrayReverse
    {
        public int[] ArrayReverse(int[] arr)
        {
            
            int arrSize = arr.Length;
            if (arrSize <= 1)
            {
                return arr;
            }
            //Loop the first half of arr to swap
            for (int i = 0; i < arrSize / 2; i++)
            {   //swap the current element with left corresponding side of array element
                int temp = arr[i];
                arr[i] = arr[arrSize - 1 - i];
                arr[arrSize - 1 - i] = temp;
            }
            return arr;

        }
    }
}

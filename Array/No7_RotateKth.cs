/*
 * Given an array, rotate it to the right by k steps.
 * Time Complexity : O(n)
 * Space Complexity :O(1)
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No7_RotateKth
    {
        public void rotateArr(int[]arr,int k)
        {
            int arrLength = arr.Length;
            k %= arrLength;
            rotateHelper(arr, 0, arrLength - 1);
            rotateHelper(arr, 0, k - 1);
            rotateHelper(arr,k, arrLength - 1);
           
        }
        public void rotateHelper(int[]arr,int start,int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}

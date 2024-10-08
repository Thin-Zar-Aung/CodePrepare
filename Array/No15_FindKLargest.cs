/*
 * Given an array, find the k-th largest element.
 * Time Complexity : O(n) Worst CaseO(n square)
 * Space : O log n worst cae : O(n)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No15_FindKLargest
    {
        public int LargestElement(int[] arr, int k)
        {
            int res = KthLarge(arr, 0, arr.Length - 1, arr.Length- k);
            return res;
            
        }
        private int KthLarge(int[]arr, int low,int high,int k)
        {
            int left = low;
            int right = high;
            Random r = new Random();
            int indexp = r.Next(low, high);
            int pivot = arr[indexp];
            if (low >= high)
                return arr[low];
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }

            }
            if (k >= left)
            {
               return KthLarge(arr, left, high, k);

            }
            if (k <= right)
            {
                return KthLarge(arr, low, right, k);
            }

            return arr[k];


        }
    }
}

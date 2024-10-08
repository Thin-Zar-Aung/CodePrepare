/*Sort an Array of 0s and 1s
 * Time Complexity O(n)
 * Space Complexity O(1)
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No11_ArrayZeroandOnesort
    {
        public void sortArr(int[] arr)
        {
            int[] nums ={ 1,0,1,0};
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] == 0)
                {
                    left++;
                }
               else 
                 
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;                  
                    right--;

                }
            }

        }
    }
}

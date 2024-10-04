/*
 * Identify the second largest element in the array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No6_SecondLargest
    {//loop the array
        //get the largest element and then find second largest
        //{1,3,5,6,7,}
        public int sendLargest(int[] arr)
        {
            int fstLarge = int.MinValue;
            int sndLarge = int.MinValue;
           
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > fstLarge)
                {
                    sndLarge = fstLarge;
                    fstLarge = arr[i];
                }
                if (arr[i] < fstLarge && arr[i] > sndLarge)
                {
                    sndLarge = arr[i];
            }

            }
           

            return sndLarge;
        }
       
        
    }
}

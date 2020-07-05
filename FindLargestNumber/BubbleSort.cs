using System;
using System.Collections.Generic;
using System.Text;

namespace FindLargestNumber
{
   public class BubbleSort
    {
        public static int FindLargest(int[] arrayToSort)
        {
            int i, j, temp;
            int large = 0;

            int[] arr = arrayToSort;
            for (i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            large = arr[0];
            for (i = 1; i < arr.Length; i++)
            {
                if (large < arr[i])
                    large = arr[i];
            }
            return large;
        }
    }
}

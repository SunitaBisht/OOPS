using System;
using System.Collections.Generic;
using System.Text;

namespace FindLargestNumber
{
    public class InsertionSort
    {
        public long FindLargest(long[] arrayToSort)
        {
            long i, j, temp;
            long large = 0;

            long[] arr = arrayToSort;
            long n = arr.Length;

            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            large = arr[n - 1];

            return large;
        }
    }
}
   
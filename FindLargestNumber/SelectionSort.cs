using System;
using System.Collections.Generic;
using System.Text;

namespace FindLargestNumber
{
    public class SelectionSort
    {
        public long FindLargest(long[] arrayToSort)
        {
            long i, j, temp;
            long large = 0;

            long[] arr = arrayToSort;
            long n = arr.Length;

            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            large = arr[n - 1];

            return large;
        }
    }
}

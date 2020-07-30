using System;
using System.Collections.Generic;
using System.Text;

namespace FindLargestNumber
{
    public class QuickSort
    {
        public void FindLargest(long[] arrayToSort)
        {
            long[] arr = arrayToSort;
            long n = arr.Length;
            FindLargest(arr, 0, n - 1);
        }
            public long FindLargest(long[] arrayToSort, long l, long h)
        {
            long large = 0;
            long temp, pivot, i, j;
            long[] arr = arrayToSort;
            long n = arr.Length;

            i = l;
            j = h;

            pivot = l;
            while (i < j)
            {
                while (arr[i] <= arr[pivot])
                    i++;
                while (arr[j] > arr[pivot])
                    j--;
                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                if (l < h)
                {
                    temp = arr[pivot];
                    arr[pivot] = arr[j];
                    arr[j] = temp;

                    FindLargest(arr, l, j - 1);
                    FindLargest(arr, j + 1, h);
                }
            }
            large = arr[n - 1];
            return large;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindLargestNumber
{
    public class BubbleSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayToSort"></param>
        /// <returns></returns>
        public long FindLargest(long[] arrayToSort)
        {
            long i, j, temp;
            long large = 0;

            long[] arr = arrayToSort;
            long n = arr.Length;

            for (i = 1; i < n ; i++)
            {
                for (j = 0; j < n-1; j++)
                {
                    if (arr[i] < arr[j])
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FindLargestNumber
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            int n1, n2, i;
            List<int> intList = new List<int>();

            //int[] arrayToSort = intList.ToArray();

            Console.WriteLine("Enter the numbers:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            for (i = n1 + 1; i < n2; i++)
            {
                if (i % 3 == 0)
                {
                    intList.Add(i); 
                }
            }
            int largest = BubbleSort.FindLargest(intList.ToArray());
            Console.WriteLine("The largest element is:" +largest);
        }
    }
}

          
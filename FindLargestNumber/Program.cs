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
            long n1, n2, i;
            List<long> longList = new List<long>();

            Console.WriteLine("Enter the numbers:");
            n1 = long.Parse(Console.ReadLine());
            n2 = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number for divisor:");
            long divisor = long.Parse(Console.ReadLine());

            for (i = n1 + 1; i < n2; i++)
            {
                if (i % divisor == 0)
                {
                    longList.Add(i); 
                }
            }
            InsertionSort insertion= new InsertionSort();
            long largest = insertion.FindLargest(longList.ToArray());
            Console.WriteLine("The largest element is:" +largest);
        }
    }
}


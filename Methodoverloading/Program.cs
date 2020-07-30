using System;

namespace Methodoverloading
{
    class Program
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int Sum1 = p.Add(2, 5);
            Console.WriteLine("Sum1:" + Sum1);

            int Sum2 = p.Add(3, 7, 5);
            Console.WriteLine("Sum2:"  + Sum2);

            Console.ReadKey();
        }
    }
}

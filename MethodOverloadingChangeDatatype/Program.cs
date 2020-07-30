using System;

namespace MethodOverloadingChangeDatatype
{
    class Program
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int sum1 = p.Add(3, 76);
            Console.WriteLine(sum1);

            double sum2 = p.Add(34, 6, 2);
            Console.WriteLine(sum2);

            Console.ReadKey();
        }
    }
}

using System;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = 4;
            dynamic obj1 = 4.65;

            Console.WriteLine("The type of the object are:");

            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj1.GetType());

            Console.ReadKey();
        }
    }
}

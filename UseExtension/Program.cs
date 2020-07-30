using System;

namespace UseExtension
{
    class Program
    {
        public void fun1()
        {
            Console.WriteLine("The first function:");
        }
        public void fun2()
        {
            Console.WriteLine("The Second function:");
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.fun1();
            p.fun2();
        }
    }
}

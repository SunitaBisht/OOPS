using System;

namespace Usereadonly
{
    class Program
    {
        readonly int a;

        public Program()
        {
            a = 10;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
        }
        
    }
}

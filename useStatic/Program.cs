using System;

namespace useStatic
{
    class Program
    {
        static int a = 30;
        public Program()
        {
            a++;
            Console.WriteLine("for first object:" + a);
        }
        static void Main(string[] args)
        {
            Program p1= new Program();
            Program p2= new Program();
            Program p3= new Program();
            Program p4= new Program();
        }
    }
}

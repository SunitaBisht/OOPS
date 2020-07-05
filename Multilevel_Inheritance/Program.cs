using System;

namespace Multilevel_Inheritance
{

    public class CEO
    {
        public void leader()
        {
            Console.WriteLine("CEO is a leader");
        }
    }
    public class Manager : CEO
    {
        public void Management()
        {
            Console.WriteLine("Manager work in Management");
        }
    }
    public class Employees : Manager
    {
        public void Work()
        {
            Console.WriteLine("Employees do work in Company");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employees obj = new Employees();
            obj.leader();
            obj.Management();
            obj.Work();

            Console.ReadKey();
        }
    }
}

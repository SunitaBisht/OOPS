using System;

namespace MethodHidingbyCasting
{
    public class Parent
    {
        public void method()
        {
            Console.WriteLine("This is a Parent class");
        }
    }
    public class child : Parent
    {
        public new void method()
        {
            base.method();
            Console.WriteLine("This is a child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child obj = new child();

            ((Parent)obj).method();

            Console.ReadKey();
        }
    }
}


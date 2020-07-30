using System;

namespace MethodOverriding
{
    // Base class 
    public class Parent
    {
        // virtual method 
        public virtual void method()
        {
            Console.WriteLine("This is parent class");
        }
    }
    // Derived class 
    public class Child : Parent
    {
        // Here method is overridden 
        public override void method()
        {
            Console.WriteLine("This is child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of the base class 

            Parent obj = new Parent();
            // Invoking method of the base class 
            obj.method();

            // Creating object of the derived class 
            obj = new Child();
            // Invoking method of derived class 
            obj.method();

            Console.ReadKey();
        }
    }
}

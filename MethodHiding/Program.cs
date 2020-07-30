using System;

namespace MethodHiding
{
    // Base Class 
    public class Parent
    {
        public void method()
        {
            Console.WriteLine("This is a Parent class");
        }
    }
    // Derived Class 
    public class child:Parent
    {
        // Hide the method of base class 
        // Using new keyword 
        public new void method()
        {
            Console.WriteLine("This is a child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the object of  
            // the derived class 
            child obj = new child();
            // Access the method of derived class 
            obj.method();

            Console.ReadKey();
        }
    }
}

using System;

namespace MethodOverridingWithoutvirtualOROverride
{
    public class Base
    {
        public void method()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    public class Derived : Base
    {
       new public void method()
        {
            Console.WriteLine("Derived Class Method");
        }
        class Program
        {
            static void Main(string[] args)
            {

                Base obj = new Base();
                obj.method();
                obj = new Derived();
                obj.method();
            }
        }
    }
}

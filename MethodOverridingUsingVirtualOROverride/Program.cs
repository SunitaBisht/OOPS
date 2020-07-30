using System;

namespace MethodOverridingUsingVirtualOROverride
{
    public class Base
    {
        public virtual void method()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    public class Derived : Base
    {
        public override void method()
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

                Console.ReadKey();
            }
        }
    }
}

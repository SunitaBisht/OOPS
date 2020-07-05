using System;

namespace NestedClassUse
{
   public class outer_class
    {
        public void method1()
        {
            Console.WriteLine("This is a outerclass");
        }

        public class Inner_class
        {
            public void method2()
            {
                Console.WriteLine("This is a innerClass");
            }
        }
        static void Main(string[] args)
        {
            outer_class obj1 = new outer_class();
            obj1.method1();


            outer_class.Inner_class obj2 = new outer_class.Inner_class();
            obj2.method2();

            Console.ReadKey();
            
        }
    }
}

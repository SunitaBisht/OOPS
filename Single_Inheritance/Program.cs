using System;

namespace Single_Inheritance
{
    public class BaseClass
    {
        public decimal Salary = 40000;
    }
    public class DerivedClass:BaseClass
    {
        public decimal Bonous = 12000;
    }
    class Program
    { 
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();

            Console.WriteLine("My salary is:"  + obj.Salary);
            Console.WriteLine("And Bonous is:" +obj.Bonous);

            Console.ReadKey();

        }
    }
}

using System;

namespace Hierarchical_Interface
{
    public class Father
    {
        public void DisplayFather()
        {
            Console.WriteLine("I am Father");  
        }
    }
    public class Son:Father
    {
        public void DisplaySon()
        {
            Console.WriteLine("I am Son");
        }
    }
    public class Doughter : Father
    {
        public void DisplayDoughter()
        {
            Console.WriteLine("I am Doughter");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Father obj1 = new Father();
            obj1.DisplayFather();

            Son obj2 = new Son();
           
            obj2.DisplaySon();
            //obj2.DisplayFather();

            Doughter obj3 = new Doughter(); ;
           
            obj3.DisplayDoughter();
            // obj3.DisplayFather();

            Console.ReadKey();
        }
    }
}

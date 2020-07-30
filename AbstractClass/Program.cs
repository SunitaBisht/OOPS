using System;

namespace AbstractClass
{

    public abstract class shape
    {
        public abstract void ractangle();
    }
    public class colors : shape
    {
        public override void ractangle()
        {
            Console.WriteLine("Color on ractangle");
        }
    }

    public class colorsprimary : shape
    {
        public override void ractangle()
        {
            Console.WriteLine("Colorprimary on ractangle ");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            shape sp;

            sp = new colors();
            sp.ractangle();

            sp = new colorsprimary();
            sp.ractangle();
        }
    }
}

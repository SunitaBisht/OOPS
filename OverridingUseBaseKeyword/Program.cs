using System;

namespace OverridingUseBaseKeyword
{
    public class web
    {
        string name = "Sunita";
        public virtual void showdata()
        {
            Console.WriteLine("My name is:" +name);
        }
    }
    class stream : web
    {
        string s = "Computer Science";

        public override void showdata()
        {
            
            base.showdata();
            Console.WriteLine("Stream is :" + s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stream obj = new stream();
            obj.showdata();
        }
    }
}

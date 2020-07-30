using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentpartial obj = new Studentpartial();
            obj.FirstName = "Sunita";
            obj.LastName = "Bisht";

            Console.WriteLine("Your Complete Name is:" + obj.GetCompleteName());

            Console.ReadLine();
        }
    }
}

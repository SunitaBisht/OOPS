using System;

namespace EarlyBinding
{
    class Student
    {
        public string Name;
        public string Subject;

        public void detail(string Name, string Subject)
        {
            this.Name = Name;
            this.Subject = Subject;

            Console.WriteLine("My Self:" + Name);
            Console.WriteLine("My favorite Subject is:" + Subject);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student obj = new Student();
                obj.detail("Sunita", "Maths");

                Console.ReadKey();
            }
        }
    }
}

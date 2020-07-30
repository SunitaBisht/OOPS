using System;

namespace DefineSealedClass
{
    sealed class sealedclass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            sealedclass obj = new sealedclass();
          int total=  obj.Add(2, 8);
            Console.WriteLine("The addition is:" + total);

            Console.ReadLine();
        }
    }
}

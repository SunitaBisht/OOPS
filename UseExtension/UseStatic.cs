using System;
using System.Collections.Generic;
using System.Text;

namespace UseExtension
{
   static class UseStatic
    {
        public static void fun3(this Program p)
        {
            Console.WriteLine("The third Function");
        }
    }
}

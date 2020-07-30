using System;

namespace StaticClass
{
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Sum(4, 6);
            Calculator.Store(result);

            var caltype = Calculator.Type;
            Calculator.Type = "Arithmatic";
        }
    }
}

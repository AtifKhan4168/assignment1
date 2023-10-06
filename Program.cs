using System;

namespace AtifCalculator
{
    internal class Program

    {
        private static int _result;


        //[Division]
        public static void Divide(int x, int y)

        {
            _result = x / y;
        }



        //[Multiplication]
        public static void Multiply(int x, int y)

        {
            _result = x * y;
        }


        //[Addition]
        public static void Add(int x, int y)

        {
            _result = x + y;
        }


        //[Subtraction]
        public static void Sub(int x, int y)

        {
            _result = x - y;
        }



        public static void Main(string[] args)

        {

            Divide(120, 4);
            Console.WriteLine("After Division: " + _result);

            Multiply(2, 5);
            Console.WriteLine("After Multiplication: " + _result);

            Add(4, 8);
            Console.WriteLine("After Addition: " + _result);

            Sub(5, 9);
            Console.WriteLine("After Subtraction: " + _result);

        }

    }
}    
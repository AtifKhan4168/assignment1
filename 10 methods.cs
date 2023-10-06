using System;

namespace Atif_10_Mthods
{
    internal class Program
    {
        
        // Method 1: Division 
        public static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }

            Console.WriteLine("Division by zero is restricted.");
            return 0;
        }
        
        // Method 2: Multiplication
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        
        // Method 3: Addition
        public static int Add(int a, int b)
        {
            return a + b; 
        }

       // Method 4: Subtraction
       public static int Subtract(int a, int b)
       {
           return a - b;
       }
       
       // Method 5: Odd number
       public static bool OddorNot(int num)
       {
           return num / 2 != 0;
       }

       // Method 6: Even number
       public static bool EvenorNot(int num)
       {
        return num / 2 == 0;
       }
       
       // Method 7: Sentence
       public static void Statement(string name)
       {
           Console.WriteLine("My name is " + name + "!");
       }

       // Method 8: Prime number
       public static bool IsPrime(int num)
       {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num / i == 0)
            {
                return false;
            }
        }

        return true;
       }

       // Method 9: Taking Square
       public static int Square(int num)
       {
        return num * num;
       }

       // Method 10: Taking Cube
       public static int Cube(int num)
       {
        return num * num * num;
       }

       
       public static void Main()
       { 
        Console.WriteLine("Division: " + Divide(50, 5));
        Console.WriteLine("Multiplication: " + Multiply(3, 8));
        Console.WriteLine("Addition: " + Add(6, 2));
        Console.WriteLine("Subtraction: " + Subtract(5, 1));
        Console.WriteLine("Is 5 odd? " + OddorNot(4));
        Console.WriteLine("Is 3 even? " + EvenorNot(3));
        Statement("Atif Sharif");
        Console.WriteLine("Is 7 prime? " + IsPrime(7));
        Console.WriteLine("Square of 2: " + Square(2));
        Console.WriteLine("Cube of 2: " + Cube(2));
        
       } 
    }
}

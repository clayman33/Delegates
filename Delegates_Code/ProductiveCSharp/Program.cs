using System;

namespace ProductiveCSharp
{
    public class Program
    {
        public delegate void Display(int n);

        public delegate int Operation(int a, int b);

        public static void Main()
        {
            Display display = new Printer().PrettyPrint;
            Operation operation = Product;

            Calculate(display, operation);
        }

        private static void Calculate(Display display, Operation operation)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var result = operation(a, b);

            display(result);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Product(int a, int b)
        {
            return a * b;
        }

        private static void Print(int n)
        {
            Console.WriteLine("Result is " + n);
        }
    }
}

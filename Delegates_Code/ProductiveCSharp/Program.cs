using System;

namespace ProductiveCSharp
{
    public class Program
    {
        public static void Main()
        {           

            Calculate(
                n => Console.WriteLine("Result is " + n), 
                (a, b) => a * b);
        }

        private static void Calculate(Action<int> display, Func<int, int, int> operation)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var result = operation(a, b);

            display(result);
        }                   
    }
}

using System;

namespace ProductiveCSharp
{
    public class Printer
    {
        public void PrettyPrint(int n)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("  Result is " + n);
            Console.WriteLine("---------------");
            Console.WriteLine();
        }
    }
}
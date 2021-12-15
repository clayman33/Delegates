using System;

namespace ProductiveCSharp
{
    public class Program
    {
        public static void Main()
        {           
            Console.WriteLine("How many children do you have: ");
            var TotalChildren = int.Parse(Console.ReadLine());

            while (TotalChildren > 0)
            {
                    Calculate(
                        age => Console.WriteLine("Your child is " + age),
                        (yearBorn, curYear) => curYear - yearBorn);
                    
                TotalChildren--;
            }
        }

        private static void Calculate(Action<int> display, Func<int, int, int> operation)
        {       
            Console.WriteLine("Enter the year the child was born: ");
            var yearBorn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current year: ");
            var curYear = int.Parse(Console.ReadLine());

            var result = operation(yearBorn, curYear);

            display(result);
        }                   
    }
}

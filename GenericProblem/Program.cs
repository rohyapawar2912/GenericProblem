using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaximumFinder finder = new MaximumFinder();

            // Test with different scenarios
            int result1 = finder.FindMaxNumber(5, 10, 8);
            Console.WriteLine($"The maximum number is: {result1}");

            int result2 = finder.FindMaxNumber(12, 15, 9);
            Console.WriteLine($"The maximum number is: {result2}");

            int result3 = finder.FindMaxNumber(18, 20, 14);
            Console.WriteLine($"The maximum number is: {result3}");
        }
    }
}

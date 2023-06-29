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
            Float finder = new Float();

            // Test with different scenarios
            float result1 = finder.FindMaxNumber(3.7f, 2.5f, 4.8f);
            Console.WriteLine($"The maximum number is: {result1}");

            float result2 = finder.FindMaxNumber(6.2f, 9.1f, 5.4f);
            Console.WriteLine($"The maximum number is: {result2}");

            float result3 = finder.FindMaxNumber(1.9f, 7.3f, 6.5f);
            Console.WriteLine($"The maximum number is: {result3}");

        }
    }
}

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
            MaxValue finder = new MaxValue();

            // Test with different scenarios
            int intResult = finder.FindMax(10, 5, 8);
            Console.WriteLine($"The maximum integer is: {intResult}");

            double doubleResult = finder.FindMax(3.14, 1.23, 2.45);
            Console.WriteLine($"The maximum double is: {doubleResult}");

            string stringResult = finder.FindMax("Apple", "Peach", "Banana");
            Console.WriteLine($"The maximum string is: {stringResult}");
        }
    }
}

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
            MaxString finder = new MaxString();

            // Test with different scenarios
            string result1 = finder.FindMaxString("Apple", "Peach", "Banana");
            Console.WriteLine($"The maximum string is: {result1}");

            string result2 = finder.FindMaxString("Cat", "Dog", "Elephant");
            Console.WriteLine($"The maximum string is: {result2}");

            string result3 = finder.FindMaxString("Orange", "Grapes", "Watermelon");
            Console.WriteLine($"The maximum string is: {result3}");

        }
    }
}

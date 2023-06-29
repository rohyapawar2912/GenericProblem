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
            // Test with different scenarios
            MaxValue<int> intMaxValue = new MaxValue<int>(10, 5, 8);
            int intResult = intMaxValue.FindMax();
            Console.WriteLine($"The maximum integer is: {intResult}");

            MaxValue<double> doubleMaxValue = new MaxValue<double>(3.14, 1.23, 2.45);
            double doubleResult = doubleMaxValue.FindMax();
            Console.WriteLine($"The maximum double is: {doubleResult}");

            MaxValue<string> stringMaxValue = new MaxValue<string>("Apple", "Peach", "Banana");
            string stringResult = stringMaxValue.FindMax();
            Console.WriteLine($"The maximum string is: {stringResult}");
        }
    }
}

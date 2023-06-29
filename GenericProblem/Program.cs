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

            MaxValue<int> moreIntMaxValue = new MaxValue<int>(10, 5, 8, 15, 20);
            int moreIntResult = moreIntMaxValue.FindMax();
            Console.WriteLine($"The maximum integer is: {moreIntResult}");

            MaxValue<double> moreDoubleMaxValue = new MaxValue<double>(3.14, 1.23, 2.45, 4.56, 0.99);
            double moreDoubleResult = moreDoubleMaxValue.FindMax();
            Console.WriteLine($"The maximum double is: {moreDoubleResult}");

            MaxValue<string> moreStringMaxValue = new MaxValue<string>("Apple", "Peach", "Banana", "Orange");
            string moreStringResult = moreStringMaxValue.FindMax();
            Console.WriteLine($"The maximum string is: {moreStringResult}");
        }
    }
}

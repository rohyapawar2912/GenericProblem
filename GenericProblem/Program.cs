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
            intMaxValue.PrintMax();

            MaxValue<double> doubleMaxValue = new MaxValue<double>(3.14, 1.23, 2.45);
            doubleMaxValue.PrintMax();

            MaxValue<string> stringMaxValue = new MaxValue<string>("Apple", "Peach", "Banana");
            stringMaxValue.PrintMax();

            MaxValue<int> moreIntMaxValue = new MaxValue<int>(10, 5, 8, 15, 20);
            moreIntMaxValue.PrintMax();

            MaxValue<double> moreDoubleMaxValue = new MaxValue<double>(3.14, 1.23, 2.45, 4.56, 0.99);
            moreDoubleMaxValue.PrintMax();

            MaxValue<string> moreStringMaxValue = new MaxValue<string>("Apple", "Peach", "Banana", "Orange");
            moreStringMaxValue.PrintMax();
        }
    }
}

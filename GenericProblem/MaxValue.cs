using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class MaxValue
    {
        public T FindMax<T>(T val1, T val2, T val3) where T : IComparable<T>
        {
            T max = val1;
            if (val2.CompareTo(max) > 0)
                max = val2;
            if (val3.CompareTo(max) > 0)
                max = val3;

            return max;
        }
    }
}

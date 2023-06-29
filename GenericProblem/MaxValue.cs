using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class MaxValue<T> where T : IComparable<T>
    {
        private T val1;
        private T val2;
        private T val3;

        public MaxValue(T val1, T val2, T val3)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
        }

        public T FindMax()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class MaxValue<T> where T : IComparable<T>
    {
        private T[] values;

        public MaxValue(params T[] values)
        {
            this.values = values;
        }

        public T FindMax()
        {
            Array.Sort(values);
            return values[values.Length - 1];
        }
    }
}

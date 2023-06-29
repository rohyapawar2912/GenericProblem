using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class Float
    {
        public float FindMaxNumber(float num1, float num2, float num3)
        {
            float max = num1;
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;

            return max;
        }
    }
}

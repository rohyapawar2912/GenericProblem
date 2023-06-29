using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class MaxString
    {
        public string FindMaxString(string str1, string str2, string str3)
        {
            string max = str1;
            if (String.Compare(str2, max, StringComparison.CurrentCulture) > 0)
                max = str2;
            if (String.Compare(str3, max, StringComparison.CurrentCulture) > 0)
                max = str3;

            return max;
        }
    }
}

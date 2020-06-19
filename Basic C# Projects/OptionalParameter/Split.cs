using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Split
    {
        public static int Splitter(int total, out int remainder, int groups = 2)
        {
            int result = total / groups;
            remainder = total % groups;
            return result;
        }
    }
}

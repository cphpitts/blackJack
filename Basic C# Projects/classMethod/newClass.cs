using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod
{
    class newClass
    {
        public int value { get; set; }

        public void Divvy(out int result)
        {
            result = this.value / 2;
        }

        public void Divvy(int divisor, out int result)
        {
            result = value / divisor;
        }

        public static int Multy(int number)
        {
            int result = number * 3;
            return result;
        }
    }
}

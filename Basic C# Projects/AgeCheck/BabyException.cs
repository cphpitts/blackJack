using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheck
{
    class BabyException: Exception
    {
        public BabyException() : base() { }
        public BabyException(string message) : base(message) { }
    }
}

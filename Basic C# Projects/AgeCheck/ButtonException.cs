using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheck
{
    public class ButtonException : Exception
    {
        public ButtonException() : base() { }
        public ButtonException(string message) : base(message) { }
    }
}

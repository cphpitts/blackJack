using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Operation
    {
        public Operation(string name, string target) : this(name, target, 4) 
        { 
        }
        public Operation(string name, string target, int size)
        {
            opName = name;
            opTarget = target;
            opSize = size;
        }
        public string opName { get; set; }
        public string opTarget { get; set; }
        public int opSize { get; set; }

        public string DescribeOp()
        {
            string opDesc = String.Format("Operation: {0} will require a {2}-person team to procure some {1}", this.opName, this.opTarget, this.opSize);
            return opDesc;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOnePlayer : Player
    {
        public TwentyOnePlayer(string name, int beginningBalance): base(name, beginningBalance)
        {
        }

        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}

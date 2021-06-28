using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDating
{
    class Boys
    {
        public Boy[] FormBoyGroup(string userName)
        { 
            Boy[] BoyGroup = {new Boy("Bob"), new Boy("John"), new Boy("Will"), new Boy("Adam"), new Boy(userName)};
            return BoyGroup;
        }
    }
}

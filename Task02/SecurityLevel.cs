using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    [Flags]
    internal enum SecurityLevel
    {
        guest=1, 
        Developer=2,
        secretary=4 ,
        DBA=8
    }
}

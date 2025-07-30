using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    [Flags]
    internal enum Permissions
    {
        Read,
        write,
        Delete,
        Execute
    }
}

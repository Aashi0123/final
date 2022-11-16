using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace class_diagram
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay ) + "(),nq}")]
    class Class1 : Class1Base3
    {
        private static object DebuggerDisplay => throw new NotImplementedException();
    }
}

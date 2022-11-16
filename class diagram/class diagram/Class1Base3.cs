using System.Diagnostics;

namespace class_diagram
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal class Class1Base3
    {
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
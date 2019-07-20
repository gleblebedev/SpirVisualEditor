using System.Collections.Generic;

namespace SpirVGraph.Spv
{
    internal class PrintableList<T> : List<T>
    {
        public override string ToString()
        {
            return string.Format("[{0}]", string.Join(", ", this));
        }
    }
}
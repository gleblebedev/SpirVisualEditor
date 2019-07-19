using System.Collections.Generic;

namespace SpirVCodeGen
{
    internal class EmptyReadOnlyList<T>
    {
        public static readonly IReadOnlyList<T> Instance = new T[0];
    }
}
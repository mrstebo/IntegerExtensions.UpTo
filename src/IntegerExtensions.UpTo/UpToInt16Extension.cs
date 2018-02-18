using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToInt16Extension
    {
        public static IEnumerable<Int16> UpTo(this Int16 start, Int16 max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToInt64Extension
    {
        public static IEnumerable<Int64> UpTo(this Int64 start, Int64 max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

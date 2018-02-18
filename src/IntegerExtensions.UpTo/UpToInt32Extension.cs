using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToInt32Extension
    {
        public static IEnumerable<Int32> UpTo(this Int32 start, Int32 max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

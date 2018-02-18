using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToUInt64Extension
    {
        public static IEnumerable<UInt64> UpTo(this UInt64 start, UInt64 max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

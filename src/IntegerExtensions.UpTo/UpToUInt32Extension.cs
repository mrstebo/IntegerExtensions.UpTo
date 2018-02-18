using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToUInt32Extension
    {
        public static IEnumerable<UInt32> UpTo(this UInt32 start, UInt32 max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

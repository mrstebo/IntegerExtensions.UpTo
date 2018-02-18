using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToUInt16Extension
    {
        public static IEnumerable<UInt16> UpTo(this UInt16 start, UInt16 max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

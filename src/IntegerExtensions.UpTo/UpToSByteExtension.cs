using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToSByteExtension
    {
        public static IEnumerable<SByte> UpTo(this SByte start, SByte max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

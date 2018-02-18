using System;
using System.Collections.Generic;

namespace IntegerExtensions.UpTo
{
    public static class UpToByteExtension
    {
        public static IEnumerable<Byte> UpTo(this Byte start, Byte max)
        {
            for (var i = start; i <= max; i++) yield return i;
        }
    }
}

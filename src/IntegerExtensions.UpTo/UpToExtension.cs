using System.Collections.Generic;
using System.Linq;

namespace IntegerExtensions.UpTo
{
    public static class UpToExtension
    {
        public static IEnumerable<int> UpTo(this int start, int max)
        {
            return Enumerable.Range(start, max - start + 1);
        }
    }
}

using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToUInt64ExtensionTests
    {
        [Test]
        [TestCase((UInt64)0, (UInt64)5, new UInt64[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((UInt64)5, (UInt64)8, new UInt64[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(UInt64 start, UInt64 max, UInt64[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((UInt64)5, (UInt64)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(UInt64 start, UInt64 max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new UInt64[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((UInt64)1, (UInt64)1, new UInt64[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(UInt64 start, UInt64 max, UInt64[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

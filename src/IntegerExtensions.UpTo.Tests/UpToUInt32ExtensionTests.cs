using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToUInt32ExtensionTests
    {
        [Test]
        [TestCase((UInt32)0, (UInt32)5, new UInt32[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((UInt32)5, (UInt32)8, new UInt32[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(UInt32 start, UInt32 max, UInt32[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((UInt32)5, (UInt32)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(UInt32 start, UInt32 max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new UInt32[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((UInt32)1, (UInt32)1, new UInt32[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(UInt32 start, UInt32 max, UInt32[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

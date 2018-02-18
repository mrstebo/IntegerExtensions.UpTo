using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToUInt16ExtensionTests
    {
        [Test]
        [TestCase((UInt16)0, (UInt16)5, new UInt16[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((UInt16)5, (UInt16)8, new UInt16[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(UInt16 start, UInt16 max, UInt16[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((UInt16)5, (UInt16)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(UInt16 start, UInt16 max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new UInt16[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((UInt16)1, (UInt16)1, new UInt16[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(UInt16 start, UInt16 max, UInt16[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToSByteExtension
    {
        [Test]
        [TestCase((SByte)0, (SByte)5, new SByte[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((SByte)5, (SByte)8, new SByte[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(SByte start, SByte max, SByte[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((SByte)5, (SByte)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(SByte start, SByte max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new SByte[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((SByte)1, (SByte)1, new SByte[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(SByte start, SByte max, SByte[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

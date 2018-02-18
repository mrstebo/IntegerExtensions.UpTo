using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToInt64ExtensionTests
    {
        [Test]
        [TestCase((Int64)0, (Int64)5, new Int64[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((Int64)5, (Int64)8, new Int64[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(Int64 start, Int64 max, Int64[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((Int64)5, (Int64)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(Int64 start, Int64 max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new Int64[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((Int64)1, (Int64)1, new Int64[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(Int64 start, Int64 max, Int64[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

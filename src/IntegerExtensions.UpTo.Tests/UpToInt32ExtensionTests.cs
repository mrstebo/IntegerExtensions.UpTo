using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToInt32ExtensionTests
    {
        [Test]
        [TestCase(0, 5, new Int32[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(5, 8, new Int32[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(Int32 start, Int32 max, Int32[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(5, 4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(Int32 start, Int32 max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new Int32[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1, 1, new Int32[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(Int32 start, Int32 max, Int32[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

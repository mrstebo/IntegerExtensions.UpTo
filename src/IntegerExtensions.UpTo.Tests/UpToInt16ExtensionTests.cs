using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToInt16ExtensionTests
    {
        [Test]
        [TestCase((Int16)0, (Int16)5, new Int16[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((Int16)5, (Int16)8, new Int16[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(Int16 start, Int16 max, Int16[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((Int16)5, (Int16)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(Int16 start, Int16 max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new Int16[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((Int16)1, (Int16)1, new Int16[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(Int16 start, Int16 max, Int16[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

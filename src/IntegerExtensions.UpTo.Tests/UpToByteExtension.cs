using NUnit.Framework;
using System;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToByteExtension
    {
        [Test]
        [TestCase((Byte)0, (Byte)5, new Byte[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase((Byte)5, (Byte)8, new Byte[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(Byte start, Byte max, Byte[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((Byte)5, (Byte)4)]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array(Byte start, Byte max)
        {
            var result = start.UpTo(max).ToArray();
            var expected = new Byte[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase((Byte)1, (Byte)1, new Byte[] { 1 })]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item(Byte start, Byte max, Byte[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }
    }
}

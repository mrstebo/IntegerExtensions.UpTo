using NUnit.Framework;
using System.Linq;

namespace IntegerExtensions.UpTo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class UpToExtensionTests
    {
        [Test]
        [TestCase(0, 5, new[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(5, 8, new[] { 5, 6, 7, 8 })]
        public void UpTo_return_array_for_range(int start, int max, int[] expected)
        {
            var result = start.UpTo(max).ToArray();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void UpTo_when_max_is_lower_than_start_returns_empty_array()
        {
            const int start = 5;
            const int max = 4;

            var result = start.UpTo(max).ToArray();
            var expected = new int[] { };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void UpTo_when_max_is_the_same_as_start_returns_array_with_one_item()
        {
            const int start = 1;
            const int max = 1;

            var result = start.UpTo(max).ToArray();
            var expected = new[] { 1 };

            Assert.AreEqual(expected, result);
        }
    }
}

using CountWords;
using System;
using System.Linq;
using Xunit;

namespace HardUnitTest1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Hello world", 2)]
        [InlineData("  This   is a    test  ", 4)]
        [InlineData("One-word", 1)]
        [InlineData("Hello, world!", 2)]
        [InlineData("Hello\tworld\tagain", 3)]
        [InlineData("", 0)]
        [InlineData("    ", 0)]
        public void CountWords_ShouldReturnCorrectWordCount(string input, int expectedCount)
        {
            var a = new CountOfWords();
            int result = a.CountWords(input);
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CountWords_ShouldThrowArgumentNullException_ForNullInput()
        {
            var a = new CountOfWords();
            Assert.Throws<ArgumentNullException>(() => a.CountWords(null));
        }
    }
}

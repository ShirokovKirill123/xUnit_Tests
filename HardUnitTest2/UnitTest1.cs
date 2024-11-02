using System;
using System.Linq;
using Xunit;
using ContainsSubstring;

namespace HardUnitTest2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Hello world", "WORLD", true, false, true)]
        [InlineData("Hello world", "WORLD", false, false, false)]
        [InlineData("Hello\tworld", "helloworld", true, true, true)]
        [InlineData("Hello world", "hello", true, false, true)]
        [InlineData("Sample text with spaces", "textwithspaces", false, true, true)]
        [InlineData("Exact match", "Exact match", false, false, true)]
        [InlineData("Exact match", "NO MATCH", false, false, false)]
        [InlineData("CaseSensitive", "casesensitive", true, false, true)]
        [InlineData("SpaceSensitive", "Space Sensitive", false, true, true)]

        public void ContainsSubstring_ShouldReturnCorrectResult(string input, string substring, bool ignoreCase, bool ignoreWhitespace, bool expectedResult)
        {
            var a = new ContSubstring();
            bool result = a.ContainsSubstring(input, substring, ignoreCase, ignoreWhitespace);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ContainsSubstring_ShouldThrowArgumentNullException_ForNullInput()
        {
            var a = new ContSubstring();
            Assert.Throws<ArgumentNullException>(() => a.ContainsSubstring(null, "test"));
        }

        [Fact]
        public void ContainsSubstring_ShouldThrowArgumentNullException_ForNullSubstring()
        {
            var a = new ContSubstring();
            Assert.Throws<ArgumentNullException>(() => a.ContainsSubstring("test", null));
        }
    }
}

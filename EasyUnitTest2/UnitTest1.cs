using System;
using System.Linq;
using Xunit;
using _2E_PalindromeCheck;

namespace EasyUnitTest2
{
    public class UnitTest1
    {       
            [Fact]
            public void IsPalindrome_ReturnsTrue_ForPalindromeString()
            {
                var a = new Palindrome();
                Assert.True(a.IsPalindrome("anna"));
            }

            [Fact]
            public void IsPalindrome_ReturnsFalse_ForNonPalindromeString()
            {
                var a = new Palindrome();
                Assert.False(a.IsPalindrome("hello"));
            }

            [Fact]
            public void IsPalindrome_ThrowsArgumentNullException_WhenInputIsNull()
            {
                var a = new Palindrome();
                Assert.Throws<ArgumentNullException>(() => a.IsPalindrome(null));
            }        
    }
}

using System;
using System.Linq;
using Xunit;
using __3E_LinelengthCheck;

namespace EsayUnitTest3
{
    public class UnitTest1
    {
            [Fact]
            public void GetStringLength_ReturnsCorrectLength_ForNonEmptyString()
            {
                var a = new LineLength();
                Assert.Equal(5, a.GetStringLength("hello"));
            }

            [Fact]
            public void GetStringLength_ReturnsZero_ForEmptyString()
            {
                var a = new LineLength();
                Assert.Equal(0, a.GetStringLength(""));
            }

            [Fact]
            public void GetStringLength_ThrowsArgumentNullException_WhenInputIsNull()
            {
                var a = new LineLength();
                Assert.Throws<ArgumentNullException>(() => a.GetStringLength(null));
            }
    }
}

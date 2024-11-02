using System;
using System.IO.Ports;
using System.Linq;
using Xunit;
using _1_Parity_Check;
using System.Security.Cryptography;

namespace EasyUnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void IsEven_ReturnsTrue_ForEvenNumber()
        {
            var even = new ParityCheck();
            Assert.True(even.IsEven(4)); // четное число
        }

        [Fact]
        public void IsEven_ReturnsFalse_ForOddNumber()
        {
            var odd = new ParityCheck();
            Assert.False(odd.IsEven(3)); // нечетное число
        }
    }
}

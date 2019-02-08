using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Multiply_WorksWithTwoPositiveIntegers()
        {
            var expected = 4;
            var a = 2;
            var b = 2; 
            var actual = multiply(a, b);
            Assert.Equal(expected,actual);
        }

       

      

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(12,4,3)]
        [InlineData(0, 0,0)]
        public void Multiply_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, multiply(n1, n2));
        }
         


        // for more see https://xunit.github.io/docs/getting-started/netcore/cmdline

        int multiply(int x, int y)
        {
            return x * y;
        }

       
    }
}

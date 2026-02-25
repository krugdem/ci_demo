using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci_demo.tests
{
    public class CalcTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(-1, 6)]
        public void InputTwoNumber_ResutSum(int first, int second)
        {
            var calc = new Calc();
            Assert.Equal(first + second, calc.Add(first, second));
        }

        [Fact]
        public void Test1()
        {
            var calc = new Calc();
            Assert.Equal(4, calc.Add(2, 2));
        }
    }
}

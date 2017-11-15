using System;
using Xunit;

namespace MvcMovie.Tests
{
    public class BasicTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2,2) );
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2,2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void TheoryExample(int value)
        {
            Assert.True(IsOdd(value));

        }
        int Add (int x, int y)
        {
            return x+y;

        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}

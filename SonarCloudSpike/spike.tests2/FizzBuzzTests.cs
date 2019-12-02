using spike.codebase;
using Xunit;

namespace spike.tests2
{
    public class FizzBuzzTests
    {
        [Fact]
        public void WhenGivenOneReturnsOne()
        {
            Assert.Equal("1", FizzBuzz.doFizzBuzz(1));
        }

        [Fact]
        public void WhenGivenTwoReturnsTwo()
        {
            Assert.Equal("2", FizzBuzz.doFizzBuzz(2));
        }
        
        [Fact]
        public void WhenGivenFourReturnsFour()
        {
            Assert.Equal("4", FizzBuzz.doFizzBuzz(4));
        }

        [Fact]
        public void WhenGivenSevenReturnsSeven()
        {
            Assert.Equal("7", FizzBuzz.doFizzBuzz(7));
        }

        [Fact]
        public void WhenGivenThreeReturnsFizz()
        {
            Assert.Equal("Fizz", FizzBuzz.doFizzBuzz(3));
        }

        [Fact]
        public void WhenGivenFiveReturnsBuzz()
        {
            Assert.Equal("Buzz", FizzBuzz.doFizzBuzz(5));
        }
    }
}
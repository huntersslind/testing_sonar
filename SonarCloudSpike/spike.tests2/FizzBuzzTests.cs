using spike.codebase;
using Xunit;

namespace spike.tests2
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz = new FizzBuzz();
        [Fact]
        public void WhenGivenOneReturnsOne()
        {
            Assert.Equal("1", _fizzBuzz.doFizzBuzz(1));
        }

        [Fact]
        public void WhenGivenTwoReturnsTwo()
        {
            Assert.Equal("2", _fizzBuzz.doFizzBuzz(2));
        }
        
        [Fact]
        public void WhenGivenFourReturnsFour()
        {
            Assert.Equal("4", _fizzBuzz.doFizzBuzz(4));
        }

        [Fact]
        public void WhenGivenSevenReturnsSeven()
        {
            Assert.Equal("7", _fizzBuzz.doFizzBuzz(7));
        }

        [Fact]
        public void WhenGivenThreeReturnsFizz()
        {
            Assert.Equal("Fizz", _fizzBuzz.doFizzBuzz(3));
        }

        [Fact]
        public void WhenGivenFiveReturnsBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzz.doFizzBuzz(5));
        }
    }
}
using RecursionPractice;
using Xunit;

namespace RecursionPracticeTests
{
    public class MathMethodsTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        public void GetFactorial_GivenNumber_ReturnsExpectedNumber(int number, int expected)
        {
            var result = MathMethods.GetFactorial(number);

            Assert.Equal(expected, result);
        }
    }
}

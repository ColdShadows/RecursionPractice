using Xunit;

namespace RecursionPractice
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 0, 1)]
        [InlineData(1, 8, 1)]
        [InlineData(4, 1, 4)]
        [InlineData(2, 5, 32)]
        public void GetPowerOf_GivenNumberAndPower_ReturnMatchesExpectedValue(int number, int power, int expected)
        {
            var result = number.GetPowerOf(power);

            Assert.Equal(expected, result);
        }
    }
}

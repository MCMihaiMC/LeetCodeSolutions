using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class ThirdMaximumTests
    {
        [Theory]
        [InlineData(
            new int[] { 3, 2, 1 }, 1)]
        [InlineData(
            new int[] { 1, 2 }, 2)]
        [InlineData(
            new int[] { 2, 2, 3, 1 }, 1)]
        [InlineData(
            new int[] { 1, 2, 2 }, 2)]
        [InlineData(
            new int[] { 1, 2, 2, 5, 3, 5 }, 2)]
        public void ThirdMaxTest(int[] nums, int expected)
        {
            //Arrange & Act
            var sut = new ThirdMaximum();
            int result = sut.ThirdMax(nums);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

using System.Linq;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class MaxIntervalTest
    {
        [Theory]
        [InlineData(
           new int[] { 37, 7, 22, 15, 49, 60 },
                        3, 48, 14)]
        public void MaximumNumbersInIntervalTest(int[] nums, int lower, int upper, int expected)
        {
            //Arrange & Act
            int result = MaxInterval.MaximumNumbersInInterval(nums.ToList(), lower, upper);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}

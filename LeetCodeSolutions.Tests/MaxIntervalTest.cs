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
            // Main interval: 3, 48

            // Order the array: {37, 7, 22, 15, 49, 60}
            //                  {7, 15, 22, 37, 49, 60}

            //Arrange & Act
            int result = MaxInterval.MaximumNumbersInInterval(nums.ToList(), lower, upper);

            //Assert
            Assert.Equal(expected, result);

        }
    }
}

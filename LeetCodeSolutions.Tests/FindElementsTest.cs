using Xunit;
using System.Collections.Generic;

namespace LeetCodeSolutions.Tests
{
    public class FindElementsTest
    {

        [Theory]
        [InlineData(
                new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [InlineData(
                new int[] { 1, 0, 1, 1, 0, 1 }, 2)]
        [InlineData(
                new int[] { 0, 1 }, 1)]
        public void FindMaxConsecutiveDigitsTest(int[] nums, int expected)
        {
            //Arrange & Act
            var sut = new FindElements();
            int result  = sut.FindMaxConsecutiveDigits(nums);

            //Assert
            Assert.Equal(expected, result);

            // Next step => introduce more values for test [1,0,1,1,0,1], [1,1,0,1,1,1], [0,1], [1,0], [1], [0]
        }

        [Fact]
        public void FindNumbersWithEvenNumberOfDigitsTest()
        {
            //Arrange
            int[] nums = { 555, 901, 482, 1771 };
            int expected = 1;

            //Act
            var sut = new FindElements();
            int result = sut.FindNumbersWithEvenNumberOfDigits(nums);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortedSquaresTest()
        {
            //Arrange
            int[] nums = { -4, -1, 0, 3, 10 };
            int[] expected = { 0, 1, 9, 16, 100 };

            //Act
            var sut = new FindElements();
            int[] result = sut.SortedSquares(nums);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }

        }
    }


}

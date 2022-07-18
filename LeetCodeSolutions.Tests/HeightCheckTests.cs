using System;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class HeightCheckTests
    {
        [Theory]
        [InlineData(
           new int[] { 1, 1, 4, 2, 1, 3 }, 3,
           new int[] { 1, 1, 1, 2, 3, 4 })]
        [InlineData(
           new int[] { 5, 1, 2, 3, 4 }, 5,
           new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(
           new int[] { 1, 2, 3, 4, 5 }, 0,
           new int[] { 1, 2, 3, 4, 5 })]
        public void HeightCheckerTest(int[] heights, int wrongPositioned, int[] expected)
        {
            //Arrange & Act
            var sut = new HeightCheck();
            int result = sut.HeightChecker(heights);

            Array.Sort(heights);

            //Assert
            Assert.Equal(wrongPositioned, result);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], heights[i]);
            }
        }
    }
}

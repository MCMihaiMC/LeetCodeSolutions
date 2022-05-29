using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class DuplicateZerosTests
    {
        [Theory]
        [InlineData(
            new int[] { 1, 5, 2, 0, 6, 8, 0, 6, 0 }, 
            new int[] { 1, 5, 2, 0, 0, 6, 8, 0, 0 })]
        [InlineData(
            new int[] { 1, 0, 2, 3, 0, 4, 5, 0 },
            new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        public void DuplicateZerosTest(int[] nums, int[] expected)
        {
            //Arrange & Act
            var sut = new DuplicateZeros();
            sut.DuplicateZerosV2(nums);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }
    }
}

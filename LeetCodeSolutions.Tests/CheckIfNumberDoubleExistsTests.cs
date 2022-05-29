using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class CheckIfNumberDoubleExistsTests
    {
        [Theory]
        [InlineData(
            new int[] { 10, 2, 5, 3 }, true)]
        [InlineData(
            new int[] { -10, 12, -20, -8, 15 }, true)]
        public void CheckIfExistTest(int[] arr, bool expected)
        {
            //Arrange & Act
            var sut = new CheckIfNumberDoubleExists();
            bool result = sut.CheckIfExist(arr);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

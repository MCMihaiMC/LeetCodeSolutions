using Xunit;

namespace LeetCodeSolutions.Tests
{

    public class MountainArrayTest
    {
        [Theory]
        [InlineData(
            new int[] { 2, 1 }, false)]
        [InlineData(
            new int[] { 3, 5, 5 }, false)]
        [InlineData(
            new int[] { 0, 3, 2, 1 }, true)]
        [InlineData(
            new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, false)]
        [InlineData(
            new int[] { 3, 7, 6, 4, 3, 0, 1, 0 }, false )]
        public void ValidMountainArrayTest(int[] arr, bool expected)
        {
            //Arrange & Act
            var sut = new MountainArray();
            bool result = sut.ValidMountainArray(arr);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

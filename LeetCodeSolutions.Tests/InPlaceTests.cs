using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class InPlaceTests
    {
        [Theory]
        [InlineData(
           new int[] { 9, -2, -9, 11, 56, -12, -3 }, 7,
           new int[] { 81, -2, 81, 11, 3136, -12, 9 } )]
        public void SquareEvenTest(int[] arr, int len, int[] expected)
        {
            //Arrange & Act
            var sut = new InPlace();
            int[] result = sut.SquareEven(arr, len);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(
          new int[] { 17, 18, 5, 4, 6, 1 },
          new int[] { 18, 6, 6, 6, 1, -1 })]
        [InlineData(
          new int[] { 400 },
          new int[] { -1 })]
        public void ReplaceElementsTest(int[] arr, int[] expected)
        {
            //Arrange & Act
            var sut = new InPlace();
            int[] result = sut.ReplaceElements(arr);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(
          new int[] { 1, 1, 2 },
          new int[] { 1, 2 })]
        [InlineData(
          new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
          new int[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicatesTest(int[] inputArr, int[] expectedArr)
        {
            //Arrange & Act
            var sut = new InPlace();
            int[] result = sut.RemoveDuplicates(inputArr);

            //Assert
            for (int i = 0; i < expectedArr.Length; i++)
            {
                Assert.Equal(expectedArr[i], result[i]);
            }

        }

        [Theory]
        [InlineData(
          new int[] { 1, 1, 2 },
          new int[] { 1, 2 })]
        [InlineData(
          new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
          new int[] { 0, 1, 2, 3, 4 })]
        public void CopyWithRemovedDuplicatesTest(int[] nums, int[] expectedArr)
        {
            //Arrange & Act
            var sut = new InPlace();
            int[] result = sut.CopyWithRemovedDuplicates(nums);

            //Assert
            for (int i = 0; i < expectedArr.Length; i++)
            {
                Assert.Equal(expectedArr[i], result[i]);
            }
        }

        [Theory]
        [InlineData(
          new int[] { 1, 1, 2 },
          new int[] { 1, 2 }, 2)]
        [InlineData(
          new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
          new int[] { 0, 1, 2, 3, 4 }, 5)]
        public void RemoveDuplicatesFromSortedArrayTest(int[] nums, int[] expected, int expectedLength)
        {
            //Arrange & Act
            var sut = new InPlace();
            int result = sut.RemoveDuplicatesFromSortedArray(nums);


            //Assert
            Assert.Equal(result, expectedLength);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }
    }
}

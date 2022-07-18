using System.Collections.Generic;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class InPlaceTests
    {
        [Theory]
        [InlineData(
           new int[] { 9, -2, -9, 11, 56, -12, -3 }, 7,
           new int[] { 81, -2, 81, 11, 3136, -12, 9 })]
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

        [Theory]
        [InlineData(
          new int[] { 0, 1, 0, 3, 12 },
          new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(
          new int[] { 0 },
          new int[] { 0 })]
        public void MoveZeroesTest(int[] nums, int[] expected)
        {
            //Arrange & Act
            var sut = new InPlace();
            sut.MoveZeroes(nums);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }

        [Theory]
        [InlineData(
          new int[] { 3, 1, 2, 4 },
          new int[] { 2, 4, 3, 1 })]
        [InlineData(
          new int[] { 0 },
          new int[] { 0 })]
        public void SortArrayByParityTest(int[] nums, int[] expected)
        {
            // The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
            //Arrange & Act
            var sut = new InPlace();
            int[] result = sut.SortArrayByParity(nums);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(
          new int[] { 3, 2, 2, 3 }, 3,
          new int[] { 2, 2, 3, 3 }, 2)]
        [InlineData(
          new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2,
          new int[] { 0, 1, 4, 0, 3 }, 5)]
        [InlineData(
          new int[] { 3, 3 }, 3,
          new int[] { }, 0)]
        [InlineData(
          new int[] { 1 }, 1,
          new int[] { }, 0)]
        [InlineData(
          new int[] { 4, 5 }, 5,
          new int[] { 4 }, 1)]
        public void RemoveElementTest(int[] nums, int val, int[] expected, int expectedOutput)
        {
            //Arrange & Act
            var sut = new InPlace();
            int result = sut.RemoveElement(nums, val);

            //Assert
            Assert.Equal(expectedOutput, result);

            for (int i = 0; i < expectedOutput; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }

        [Theory]
        [InlineData(
            new int[] { 3, 2, 2, 3 }, 3,
            new int[] { 2, 2, 3, 3 }, 2)]
        [InlineData(
            new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2,
            new int[] { 0, 1, 4, 0, 3 }, 5)]
        [InlineData(
            new int[] { 3, 3 }, 3,
            new int[] { }, 0)]
        [InlineData(
            new int[] { 1 }, 1,
            new int[] { }, 0)]
        [InlineData(
            new int[] { 4, 5 }, 5,
            new int[] { 4 }, 1)]
        public void RemoveElementCarmenWayTest(int[] nums, int val, int[] expected, int expectedOutput)
        {
            //Arrange & Act
            var sut = new InPlace();
            int result = sut.RemoveElementCarmenWay(nums, val);

            //Assert
            Assert.Equal(expectedOutput, result);

            for (int i = 0; i < expectedOutput; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }

        [Theory]
        [InlineData(
            new int[] { 4, 3, 2, 7, 8, 2, 3, 1 },
            new int[] { 5, 6 })]
        [InlineData(
            new int[] { 1, 1 },
            new int[] { 2 })]
        public void FindDisappearedNumbersTest(int[] nums, int[] expected)
        {
            //Arrange & Act
            var sut = new InPlace();
            IList<int> result = sut.FindDisappearedNumbers(nums);

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }

        }

    }
}

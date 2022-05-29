using Xunit;

namespace LeetCodeSolutions.Tests
{

    public class RemoveArrayElementTest
    {
        // Input: nums = [3, 2, 2, 3], val = 3
        // Output: 2, nums = [2, 2, _, _]

        // Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
        // Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]

        //Input: [0,1,2,2,3,0,4,2], val = 2
        //Output: [0,1,2,3,0]
        //Expected: [0,1,4,0,3]

        [Theory]
        [InlineData(
        new int[] { 3, 2, 2, 3 }, 2,
        new int[] { 3, 3 }, 2)]
        [InlineData(
        new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2,
        new int[] { 0, 1, 3, 0, 4}, 5)]
        public void RemoveElementTest(int[] nums, int val, int[] expectedNums, int expected)
        {
            //Arrange & Act
            var sut = new RemoveArrayElement();
            int result = sut.RemoveElementV2(nums, val);

            int[] resultArr = new int[result];

            for (int i = 0; i < result; i++)
                resultArr[i] = nums[i];

            //Assert
            Assert.Equal(expected, result);

            for (int i = 0; i < result; i++)
                Assert.Equal(expectedNums[i], resultArr[i]);
        }


//        int[] nums = [...]; // Input array
//        int val = ...; // Value to remove
//        int[] expectedNums = [...]; // The expected answer with correct length.
//                                    // It is sorted with no values equaling val.

//        int k = removeElement(nums, val); // Calls your implementation

//        assert k == expectedNums.length;
//          sort(nums, 0, k); // Sort the first k elements of nums
//          for (int i = 0; i<actualLength; i++) {
//              assert nums[i] == expectedNums[i];
//         }

    }
}

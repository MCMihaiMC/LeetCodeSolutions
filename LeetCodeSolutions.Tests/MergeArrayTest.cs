using System.Collections.Generic;
using Xunit;

namespace LeetCodeSolutions.Tests
{
    public class MergeArrayTest
    {
        [Theory]
        [InlineData(
            new int[] { 1, 2, 3, 0, 0, 0 }, 3,
            new int[] { 2, 5, 6 }, 3,
            new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new int[] { 0 }, 0,
            new int[] { 1 }, 1,
            new int[] { 1 })]
        [InlineData(
            new int[] { 1 }, 1,
            new int[] { }, 0,
            new int[] { 1 })]
        [InlineData(
            new int[] { }, 0,
            new int[] { 1 }, 1,
            new int[] { 1 })]
        [InlineData(
            new int[] { 2, 0 }, 1,
            new int[] { 1 }, 1,
            new int[] { 1, 2 })]
        [InlineData(
            new int[] { 1, 0 }, 1,
            new int[] { 2 }, 1,
            new int[] { 1, 2 })]
        [InlineData(
            new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, 6,
            new int[] { 1, 2, 2 }, 3,
            new int[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
        [InlineData(
            new int[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 }, 3,
            new int[] { -1, 1, 1, 1, 2, 3 }, 6,
            new int[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            int countNums1 = 0;
            countNums1 = nums1.Length - nums2.Length;

            var sut = new MergeArrays();
            sut.Merge(nums1, countNums1, nums2, nums2.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                if (countNums1 > 0)
                    Assert.Equal(expected[i], nums1[i]);
                else
                    Assert.Equal(expected[i], nums2[i]);
            }

        }

        // ClassData
        [Theory]
        [MemberData(nameof(MergeData))]
        public void MergeTestMemberData(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            var test = new int[][] { new int[] { 1, 2, 3 } };

            int countNums1 = 0;
            countNums1 = nums1.Length - nums2.Length;

            var sut = new MergeArrays();
            sut.Merge(nums1, countNums1, nums2, nums2.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                if (countNums1 > 0)
                    Assert.Equal(expected[i], nums1[i]);
                else
                    Assert.Equal(expected[i], nums2[i]);
            }
        }

        public static IEnumerable<object[]> MergeData()
        {
            //valid data set
            yield return new object[]
            {
                new int[] { 1, 2, 3, 0, 0, 0 }, 3,
                new int[] { 2, 5, 6 }, 3,
                new int[] { 1, 2, 2, 3, 5, 6 }

            };
            yield return new object[]
            {
                new int[] { 0 }, 0,
                new int[] { 1 }, 1,
                new int[] { 1 }
            };
        }
    }
}

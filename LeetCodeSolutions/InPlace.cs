﻿using System;
using System.Linq;

namespace LeetCodeSolutions
{
    public class InPlace
    {
        #region InPlace example
        // InPlace example
        // Input: array = [9, -2, -9, 11, 56, -12, -3]
        // Output: [81, -2, 81, 11, 3136, -12, 9]
        // Explanation: The numbers at even indexes(0, 2, 4, 6) have been squared,
        // whereas the numbers at odd indexes(1, 3, 5) have been left the same.

        public int[] SquareEven(int[] arr, int len)
        {
            if (arr == null)
            {
                return null;
            }

            int[] result = new int[len];

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] *= arr[i];
                }
                result[i] = arr[i];
            }

            return result;
        }


        #endregion

        public int[] ReplaceElements(int[] arr)
        {
            var maxValue = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > maxValue)
                {
                    int tempValue = arr[i];

                    if (maxValue == 0)
                    {
                        arr[i] = -1;
                    }
                    else
                    {
                        arr[i] = maxValue;
                    }

                    maxValue = tempValue;
                }
                else
                {
                    arr[i] = maxValue;
                }
            }

            return arr;

        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3256/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RemoveDuplicates(int[] nums)
        {
            int arrLength = nums.Length;

            for (int i = arrLength - 2; i >= 0; i--)
            {
                if (nums[i] == nums[i + 1])
                {
                    for (int j = i + 1; j < arrLength; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    arrLength--;
                    Array.Resize(ref nums, arrLength);
                }
            }

            return nums;
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3256/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] CopyWithRemovedDuplicates(int[] nums)
        {
            // Check for edge cases.
            if (nums == null || nums.Length == 0)
                return nums;

            // Count how many unique elements are in the Array.
            int uniqueNumbers = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // An element should be counted as unique if it's the first
                // element in the Array, or is different to the one before it.
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    uniqueNumbers++;
                }
            }

            // Create a result Array.
            int[] result = new int[uniqueNumbers];

            // Write the unique elements into the result Array.
            int positionInResult = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // Same condition as in the previous loop. Except this time, we can write
                // each unique number into the result Array instead of just counting them.
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    result[positionInResult] = nums[i];
                    positionInResult++;
                }
            }

            return result;
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3258/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            var index = 1;

            // Check for edge cases.
            if (nums == null || nums.Length == 0)
                return nums.Length;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] != nums[i+1])
                {
                    nums[index] = nums[i+1];
                    index++;
                }
            }

            return index;
        }
    }

}

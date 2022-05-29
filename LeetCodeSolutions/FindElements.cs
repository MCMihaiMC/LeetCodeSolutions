using System;

namespace LeetCodeSolutions
{
    public class FindElements
    {
        public int FindMaxConsecutiveDigits(int[] nums)
        {

            int consecutiveOnes = 0;
            int maxConsecutive = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    consecutiveOnes = consecutiveOnes + 1;
                }
                else
                {
                    consecutiveOnes = 0;
                }

                if (maxConsecutive < consecutiveOnes)
                    maxConsecutive = consecutiveOnes;
            }

            return maxConsecutive;
        }

        public int FindNumbersWithEvenNumberOfDigits(int[] nums)
        {
            int countOfNumbersWithEvenNumberOfDigitsFound = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                string number = nums[i].ToString();
                if (number.Length % 2 == 0)
                    countOfNumbersWithEvenNumberOfDigitsFound++;
            }

            return countOfNumbersWithEvenNumberOfDigitsFound;
        }

        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);

            return nums;
        }
    }
}

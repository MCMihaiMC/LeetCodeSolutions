using System;
using System.Linq;

namespace LeetCodeSolutions
{
    public class ThirdMaximum
    {
        public int ThirdMax(int[] nums)
        {
            // Edge case
            if (nums.Length < 3)
                return nums.Max();

            // Extract distinct numbers
            int[] distinctNums = nums.Distinct().ToArray();

            if (distinctNums.Length < 3)
            {
                return distinctNums.Max();
            }
            else
            {
                var distinctNumsList = distinctNums.ToList();
                for (int i = 0; i < 3; i++)
                {
                    if (i < 2)
                    {
                        int maxValue = distinctNumsList.Max();
                        distinctNumsList.RemoveAt(distinctNumsList.IndexOf(maxValue));
                    }
                }
                return distinctNumsList.Max();
            }
        }
    }
}

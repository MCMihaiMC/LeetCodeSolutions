using System;
using System.Linq;

namespace LeetCodeSolutions
{
    public class RemoveArrayElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            nums = nums.Where(v => v != val).ToArray();
                
            return nums.Length;
        }

        public int RemoveElementV2(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    Array.Resize(ref nums, nums.Length - 1);
                    i--;
                }
            }

            if(nums[nums.Length - 1] == val)
                Array.Resize(ref nums, nums.Length - 1);

            //int[] expectedNums = new int[nums.Length];

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    expectedNums[i] = nums[i];
            //}

            return nums.Length;
        }
    }
}

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

            return nums.Length;
        }

        public int RemoveElementV3(int[] nums, int val)
        {
            int occurenceCount = 0;
            int[] baseArr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                baseArr[i] = nums[i];
                nums[i] = 0;
            }

            int baseArrIndex = 0;
            int numsIndex = 0;
            while(baseArrIndex < baseArr.Length)
            {
                if (baseArr[baseArrIndex] == val)
                {
                    occurenceCount++;
                }
                else
                {
                    nums[numsIndex] = baseArr[baseArrIndex];
                    numsIndex++;
                }

                baseArrIndex++;
            }
            Array.Resize(ref nums, nums.Length - occurenceCount);

            return nums.Length;
        }


        public int RemoveDuplicates(int[] nums)
        {
            int duplicatesCount = 0;

            if (nums.Length == 1)
                return nums.Length;

            if (nums.Length == 2)
            {
                if (nums[0] == nums[1])
                    return nums.Length - 1;
                else
                    return nums.Length;
            }

            int[] baseArr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                baseArr[i] = nums[i];
                nums[i] = 0;
            }

            int baseArrIndex = 0;
            int numsIndex = 0;
            while (baseArrIndex < baseArr.Length - 1)
            {
                if (baseArr[baseArrIndex] == baseArr[baseArrIndex + 1] && baseArrIndex + 1 < baseArr.Length - 1)
                {
                    duplicatesCount++;
                }
                else
                {
                    nums[numsIndex] = baseArr[baseArrIndex];
                    numsIndex++;
                }

                baseArrIndex++;
            }

            if(numsIndex == 0)
            {
                nums[numsIndex] = baseArr[baseArrIndex];
                duplicatesCount--;
            }

            if (baseArr[baseArr.Length - 1] != baseArr[baseArr.Length - 2])
                nums[numsIndex] = baseArr[baseArrIndex];
            else
                duplicatesCount++;

            Array.Resize(ref nums, nums.Length - duplicatesCount);

            return nums.Length;
        }
    }
}

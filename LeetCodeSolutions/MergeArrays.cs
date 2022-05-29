using System;

namespace LeetCodeSolutions
{
    public class MergeArrays
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] baseArr = new int[m + n];

            for (int i = 0; i < nums1.Length; i++)
            {
                baseArr[i] = nums1[i];
            }

            int baseArrIndex = 0;
            int nums1Index = 0;
            int nums2Index = 0;

            bool nums2Finalized = false;

            if (m + n == 1)
            {
                if (nums1.Length > 0)
                {
                    if (baseArr[0] != 0)
                    {
                        nums1[0] = baseArr[0];
                        return;
                    }
                }


                if (nums2.Length > 0)
                {
                    if (nums2[0] != 0)
                    {
                        Array.Resize(ref nums1, nums2.Length);
                        nums1[0] = nums2[0];
                        return;
                    }
                }
            }

            if (m == 0)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }

            if (n == 0)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums1[i] = baseArr[i];
                }
                return;
            }

            while (baseArrIndex < m + n && nums2Finalized == false)
            {
                if (baseArr[baseArrIndex] <= nums2[nums2Index] && baseArrIndex < m)
                {
                    nums1[nums1Index] = baseArr[baseArrIndex];
                    nums1Index++;
                    baseArrIndex++;
                }
                else
                {
                    nums1[nums1Index] = nums2[nums2Index];

                    if (nums2.Length - 1 > nums2Index)
                    {
                        nums2Index++;
                    }
                    else
                        nums2Finalized = true;

                    nums1Index++;
                }
            }

            if (nums2Finalized == true)
            {
                for (int i = baseArrIndex; i < m + n; i++)
                {
                    if (baseArr[i] != 0)
                    {
                        nums1[nums1Index] = baseArr[i];
                        if (nums1.Length - 1 > nums1Index)
                        {
                            nums1Index++;
                        }
                    }
                }
            }
        }
    }
}

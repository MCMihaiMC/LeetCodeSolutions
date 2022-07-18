using System;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3270/
    /// </summary>
    public class HeightCheck
    {
        public int HeightChecker(int[] heights)
        {
            int count = 0;

            int[] expectedHeights = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                expectedHeights[i] = heights[i];
            }
            Array.Sort(expectedHeights);

            for (int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != expectedHeights[i])
                {
                    count++;
                }
            }

            return count;
        }
    }

}

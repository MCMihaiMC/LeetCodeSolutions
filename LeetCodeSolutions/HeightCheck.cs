using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
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

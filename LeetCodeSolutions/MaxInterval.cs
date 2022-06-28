using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    // TEST OPIS
    public class MaxInterval
    {
        /// <summary>
        /// Add problem link
        /// </summary>
        /// <param name="excludedNumbers"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int MaximumNumbersInInterval(List<int> excludedNumbers, int l, int r)
        {
            excludedNumbers.Sort();
            int countNums = 0;
            int max = int.MinValue;
            // Verify edge cases
 
            for(int i = 1; i < excludedNumbers.Count(); i++)
            {
                // Mark the border
                if (excludedNumbers[i] > r)
                    break;

                if (excludedNumbers[i] < l)
                    continue;

                countNums = excludedNumbers[i] - excludedNumbers[i - 1] - 1;

                if (max < countNums)
                    max = countNums;
            }

            return max;

            #region bad solution
            /*
            // l = lower; r = upper;
            int initialIndex = 0;
            int numbersInInterval = initialIndex;
            int[] intervalNumbers = new int[1];
            int[] mainInterval = new int[r + 1];
            int intervals = 1;

            int firstNumberInInterval = l;

            for (int i = 1; i < r + 1; i++)
            {
                mainInterval[i] = i;
            }

            int[] excludedNumbersArray = excludedNumbers.ToArray();
            Array.Sort(excludedNumbersArray);

            for (int i = 0; i <= excludedNumbers.Count - 1; i++)
            {

                for (int j = firstNumberInInterval; j < r - 1; j++)
                {
                    if (j > r)
                        break;

                    if (mainInterval[j] == excludedNumbersArray[i])
                    {
                        // interval ended - save count
                        intervalNumbers[intervals - 1] = numbersInInterval;
                        Array.Resize(ref intervalNumbers, ++intervals);
                        numbersInInterval = 0;
                        firstNumberInInterval = j + 1;
                        break;
                    }
                    else
                    {
                        // Count numbers 
                        numbersInInterval++;
                    }
                }
            }

            // Extract maximum value from created array intervalNumbers[n]
            int result = intervalNumbers.Max();
            return result;
            */
            #endregion
        }
    }
}
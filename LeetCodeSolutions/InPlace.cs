using System;
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

            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] > maxValue)
                {
                    int tempValue = arr[i];

                    if(maxValue == 0)
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
    }
}

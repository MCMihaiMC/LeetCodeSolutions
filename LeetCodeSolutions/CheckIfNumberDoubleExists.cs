using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class CheckIfNumberDoubleExists
    {
        public bool CheckIfExist(int[] arr)
        {
            // split arrays in 2 (positive vs negative
            int[] positiveArr = new int[0];
            int positiveArrIndex = 0;
            int[] negativeArr = new int[0];
            int negativeArrIndex = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    positiveArrIndex++;
                    Array.Resize(ref positiveArr, positiveArrIndex);
                    positiveArr[positiveArrIndex - 1] = arr[i];
                }
                else
                {
                    negativeArrIndex++;
                    Array.Resize(ref negativeArr, negativeArrIndex);
                    negativeArr[negativeArrIndex - 1] = arr[i];
                }
            }

            Array.Sort(positiveArr);
            for (int i = 0; i < positiveArr.Length; i++)
            {
                for (int j = i + 1; j < positiveArr.Length; j++)
                {
                    if (positiveArr[i] * 2 == positiveArr[j])
                        return true;
                }
            }

            Array.Sort(negativeArr);
            for (int i = negativeArr.Length; i > 0; i--)
            {
                for (int j = negativeArr.Length - 1; j > 0; j--)
                {
                    if (negativeArr[i - 1] * 2 == negativeArr[j - 1])
                        return true;
                }
            }

            return false;

        }
    }
}

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

            if (arr.Length == 1)
                return new int[] { -1 };

            int[] baseArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                baseArr[i] = arr[i];
            }

            int baseArrIndex = arr.Length - 1;
            int arrIndex = arr.Length - 1;

            while (baseArrIndex > 0 )
            {
                if(baseArr[baseArrIndex] > baseArr[baseArrIndex-1] )
                {
                    arr[arrIndex - 1] = baseArr[baseArrIndex];
                    arrIndex--;
                    baseArrIndex--;
                }
                else
                {
                    arr[arrIndex] = baseArr[baseArrIndex];
                    arrIndex--;
                    baseArrIndex--;
                }

            }

            return null;
        }
    }
}

using System.Linq;

namespace LeetCodeSolutions
{
    public class MountainArray
    {
        public bool ValidMountainArray(int[] arr)
        {
            bool isMountainArray = false;            
            int maxValue = arr.Max();
            int maxIndex = arr.ToList().IndexOf(maxValue);

            if (arr.Length <= 2)
                return false;

            if (maxIndex == arr.Length - 1 || maxIndex == 0)
                return false;


            for (int i = 0; i < maxIndex; i++)
            {
                if (arr[i] < arr[i + 1])
                    isMountainArray = true;
                else
                {
                    return false;
                }
            }

            for (int i = maxIndex; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    isMountainArray = true;
                else
                {
                    return false;
                }
            }

            return isMountainArray;
        }
    }
}

using System;

namespace LeetCodeSolutions
{
    public class DuplicateZeros
    {
        public void DuplicateZerosV1(int[] arr)
        {
            int[] newArr = arr;
            int zerosCount = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == 0)
                    zerosCount++;
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == 0)
                {
                    if (arr.Length < newArr.Length + zerosCount)
                        Array.Resize(ref arr, arr.Length - 1 + zerosCount);

                    arr[i + 1] = 0;
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (j < newArr.Length - 1)
                        {
                            arr[j + 2] = newArr[j + 1];
                        }
                    }
                    Array.Resize(ref arr, newArr.Length);
                    newArr = arr;
                    i++;
                }
            }
        }

        public void DuplicateZerosV2(int[] arr)
        {

            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            int arrIndex = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (arrIndex > arr.Length - 1)
                    break;

                arr[arrIndex] = newArr[i];
                arrIndex++;
                if (newArr[i] == 0)
                {
                    if (arrIndex + 1 <= arr.Length)
                    {
                        arr[arrIndex] = newArr[i];
                        arrIndex++;
                    }
                }
            }

        }
    }
}

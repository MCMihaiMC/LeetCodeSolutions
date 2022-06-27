using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode SOLUTIONS !");

            // CREATE TEST
            // int excludedNumbersCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> excludedNumbers = new List<int>();
            excludedNumbers.Add(37);
            excludedNumbers.Add(7);
            excludedNumbers.Add(22);
            excludedNumbers.Add(15);
            excludedNumbers.Add(49);
            excludedNumbers.Add(60);

            int excludedNumbersCount = excludedNumbers.Count;

            //for (int i = 0; i < excludedNumbersCount; i++)
            //{
            //    int item = Convert.ToInt32(Console.ReadLine().Trim());
            //    excludedNumbers.Add(item);
            //}

            int lower = 3; //Convert.ToInt32(Console.ReadLine().Trim());

            int upper = 48; // Convert.ToInt32(Console.ReadLine().Trim());

            int result = MaxInterval.GetMaxInterval(excludedNumbers, lower, upper);

            Console.WriteLine(result);
        }
    }
}

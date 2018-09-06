using System;
using System.Collections.Generic;

namespace advent_2_checksum
{
    public class SpreadsheetChecksum
    {
        public static int SolveFor(List<int[]> input)
        {
            var result = 0;
            foreach (var array in input)
            {
                result += FindMinMaxDifferenceFor(array);
            }

            return result;
        }

        public static int FindMinMaxDifferenceFor(int[] array)
        {
            if (array.Length < 1)
            {
                throw new ArgumentException(nameof(array));
            }

            var min = array[0];
            var max = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max - min;
        }
    }
}

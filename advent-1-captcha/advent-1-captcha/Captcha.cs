using System;
using System.Collections;
using System.Collections.Generic;

namespace advent_1_captcha
{
    public class Captcha
    {
        public static int SolveFor(int[] input)
        {
            var result = 0;
            for (var i = 0; i < input.Length; i++)
            {
                var follower = (i + 1) % input.Length;
                if (input[follower] == input[i])
                {
                    result += input[i];
                }
            }

            return result;
        }
    }
}

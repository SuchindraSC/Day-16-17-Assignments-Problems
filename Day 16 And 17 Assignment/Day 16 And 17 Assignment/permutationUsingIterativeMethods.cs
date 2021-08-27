using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_And_17_Assignment
{
    class permutationUsingIterativeMethods
    {
        public static void Permutation(string word, string answer)
        {
            if (word.Length == 0)
            {
                Console.WriteLine(answer + " ");
            }
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                string left_substr = word.Substring(0, i);
                string right_substr = word.Substring(i + 1);
                string rest = left_substr + right_substr;
                Permutation(rest, answer + ch);
            }
        }
    }
}

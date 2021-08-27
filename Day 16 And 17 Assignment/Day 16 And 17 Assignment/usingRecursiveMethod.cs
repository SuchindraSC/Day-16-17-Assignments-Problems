using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_And_17_Assignment
{
    class usingRecursiveMethod
    {
        public static void Permutation(string word1, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(word1);
            }
            else
            {
                for (int i = 1; i <= r; i++)
                {
                    word1 = swap(word1, l, i);
                    Permutation(word1, l + 1, r);
                    word1 = swap(word1, l, i);
                }
            }
        }
        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}

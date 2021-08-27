using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day_16_And_17_Assignment
{
    class BinarySearchWord
    {
        public static int binarySearchWord(string[] nArray, string inputWord)
        {
            int left = 0, right = nArray.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int result = inputWord.CompareTo(nArray[middle]);

                if (result == 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }

        public static void inputArray()
        {
            string listofWords = File.ReadAllText(@"C:\Users\ADVANCED\Desktop\Day 16 & 17 Assignment Problems\Day 16 And 17 Assignment\ReadFile.txt");
            Console.WriteLine("Text File Contains Words: ");

            string[] words = listofWords.Split(',');
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n\nAfter Sort Operation: ");

            Array.Sort(words);
            foreach (var item in words)
            {
                Console.WriteLine(item + " ");
            }

            Console.Write("\nEnter A Word To Search In File: ");
            string searchWord = Console.ReadLine();

            int result = binarySearchWord(words, searchWord);

            if (result == -1)
            {
                Console.WriteLine("Word Not Present In File");
            }
            else
            {
                Console.WriteLine("Word Found At Position " + result);
            }

        }
    }
}

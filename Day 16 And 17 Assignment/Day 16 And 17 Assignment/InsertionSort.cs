using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_And_17_Assignment
{
    class InsertionSort
    {
        public void Insertion_Sort()
        {
            Console.WriteLine("Enter The Size Of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("Enter String Elements Of The Array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int i = 1; i < array.Length; i++)
            {
                string key = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(key) > 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

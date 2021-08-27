﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_And_17_Assignment
{
    class BubbleSort
    {
        public void Bubble_Sort()
        {
            Console.WriteLine("Enter Size of Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter String Elements of Array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            BubbleSort.Print_Array(array);
        }

        public static void Print_Array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

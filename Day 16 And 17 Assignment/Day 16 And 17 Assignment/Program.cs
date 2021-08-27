using System;

namespace Day_16_And_17_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1. PERMUTATION OF STRING USING ITERATIVE METHOD \n2. PERMUTATION OF STRING USING RECURSIVE METHOD \n3. BINARY SEARCH WORD \n4. INSERTION SORT \n5. BUBBLE SORT \n6. MERGE SORT \n7. ANAGRAM CHECK \n8. PRIME NUMBER \n9. FIND YOUR NUMBER \n10. EXIT");
                Console.WriteLine("\nEnter Your Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("1st PROBLEM");
                        Console.WriteLine("USING ITERATIVE METHOD");
                        string word;
                        string answer = " ";
                        Console.WriteLine("Enter The String: ");
                        word = Console.ReadLine();
                        Console.WriteLine("All The Possible Strings Are: ");
                        permutationUsingIterativeMethods.Permutation(word, answer);
                        break;
                    case 2:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("USING RECURSIVE METHOD");
                        Console.WriteLine("Enter The String: ");
                        string word1 = Console.ReadLine();
                        int n = word1.Length;
                        Console.WriteLine("All The Possible Strings Are: ");
                        usingRecursiveMethod.Permutation(word1, 0, n - 1);
                        break;
                    case 3:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("2nd PROBLEM");
                        Console.WriteLine("BINARY SEARCH WORD");
                        BinarySearchWord.inputArray();
                        break;
                    case 4:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("3rd PROBLEM");
                        Console.WriteLine("INSERTION SORT");
                        InsertionSort insertion = new InsertionSort();
                        insertion.Insertion_Sort();
                        break;
                    case 5:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("4th PROBLEM");
                        Console.WriteLine("BUBBLE SORT");
                        BubbleSort sort = new BubbleSort();
                        sort.Bubble_Sort();
                        break;
                    case 6:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("5th PROBLEM");
                        Console.WriteLine("MERGE SORT");
                        MergeSort sortMerge = new MergeSort();
                        sortMerge.Merge_Sort();
                        break;
                    case 7:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("6th PROBLEM");
                        Console.WriteLine("ANAGRAM CHECK");
                        AnagramCheck anagram = new AnagramCheck();
                        anagram.Check_Anagram();
                        break;
                    case 8:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("7th PROBLEM");
                        Console.WriteLine("PRIME NUMBER");
                        PrimeNumber numbers = new PrimeNumber();
                        numbers.Prime();
                        break;
                    case 9:
                        Console.WriteLine("\n\n");
                        Console.WriteLine("8th PROBLEM");
                        Console.WriteLine("PRIME NUMBER");
                        Console.WriteLine("Enter The First Value: ");
                        int firstValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Enter The Last Value: ");
                        int lastValue = int.Parse(Console.ReadLine());
                        FindYourNumber find = new FindYourNumber();
                        find.Find();
                        find.Question(firstValue,lastValue);
                        break;
                    case 10:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You Entered Wrong Input");
                        break;
                }
            }
        }
    }
}

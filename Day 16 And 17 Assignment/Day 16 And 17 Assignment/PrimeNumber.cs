using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_And_17_Assignment
{
    class PrimeNumber
    {
        public void Prime()
        {
            int i = 2;
            Console.WriteLine("Range is 0 to 1000");
            while (i < 1000)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }
    }
}

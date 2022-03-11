using System;
using System.Collections.Generic;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int shiftNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int number in numbers)
            {
                Console.Write(number + "|");
            }
            
            Console.WriteLine();

            for (int i = 0; i < shiftNumber; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j != numbers.Length - 1)
                        numbers[j] = numbers[j + 1];
                    else
                        numbers[j] = firstNumber;
                }
            }

            foreach (int number in numbers)
            {
                Console.Write(number + "|");
            }
        }
    }
}
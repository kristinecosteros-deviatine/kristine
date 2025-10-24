using System;

namespace Project
{
    class Task2
    {
        static void Main(string[] args)
        {
            // Row 0: Even numbers
            // Row 1: Odd numbers
            int[][] numberMatrix = new int[][]
                        {
                                                                                        new int[] { 2, 4, 6, 8, 10 }, // Row 0
                                                                                                        new int[] { 1, 3, 5, 7, 9 }   // Row 1
                                                                    };

            Console.WriteLine("The number matrix has been initialized.");

            // Extract digits
            int num1 = numberMatrix[1][3]; // Row 1, Index 3 → 7
            int num2 = numberMatrix[0][0]; // Row 0, Index 0 → 2
            int num3 = numberMatrix[1][4]; // Row 1, Index 4 → 9

            // Combine num into string 
            string combinedNum = num1.ToString() + num2.ToString() + num3.ToString();

            // Display the final password
            Console.WriteLine("The passkey is " + combinedNum);
        }
    }
} 


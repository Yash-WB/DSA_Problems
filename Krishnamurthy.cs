/*Check if a number is a Krishnamurthy Number or not
Last Updated : 07 Jan, 2024
A Krishnamurthy number is a number whose sum of the factorial of digits is equal to the number itself.
For example, 145 is the sum of the factorial of each digit.
1! + 4! + 5! = 1 + 24 + 120 = 145

Examples: 

Input: 145
Output: YES
Explanation: 1! + 4! + 5! =
1 + 24 + 120 = 145, which is equal to input,
hence YES.

Input : 235
Output: NO
Explanation: 2! + 3! + 5! =
2 + 6 + 120 = 128, which is not equal to input,
hence NO.*/

using System;

namespace DSA
{
    class Krishnamurthy
    {
        public static int Fact(int digit)
        {
            if (digit == 0 || digit == 1) // Base cases for factorial
                return 1;
            return digit * Fact(digit - 1); // Recursive call to calculate factorial
        }

        public static bool CheckKrishnamurthy(int n)
        {
            int sum = 0; // Initialize sum to store the sum of factorials
            int original = n; // Store the original number for comparison

            while (n != 0) // Loop to extract each digit
            {
                int digit = n % 10; // Get the last digit of the number
                sum += Fact(digit); // Add the factorial of the digit to the sum
                n = n / 10; // Remove the last digit from the number
            }

            return sum == original; // Check if the sum of factorials equals the original number
        }

        static void Main(string[] args)
        {
            int n = 145; // Number to check if it is a Krishnamurthy number
            if (Krishnamurthy.CheckKrishnamurthy(n)) // Check if the number is a Krishnamurthy number
            {
                Console.WriteLine("Krishnamurthy"); // Output if the number is a Krishnamurthy number
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy"); // Output if the number is not a Krishnamurthy number
            }
        }
    }
}


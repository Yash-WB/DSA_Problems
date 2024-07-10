/*1796. Second Largest Digit in a String

Given an alphanumeric string s, return the second largest numerical digit that appears in s, or -1 if it does not exist.

An alphanumeric string is a string consisting of lowercase English letters and digits.

 

Example 1:

Input: s = "dfa12321afd"
Output: 2
Explanation: The digits that appear in s are [1, 2, 3]. The second largest digit is 2.
Example 2:

Input: s = "abc1111"
Output: -1
Explanation: The digits that appear in s are [1]. There is no second largest digit. 
 

Constraints:

1 <= s.length <= 500
s consists of only lowercase English letters and/or digits1796. Second Largest Digit in a String
Solved
Easy
Topics
Companies
Hint
Given an alphanumeric string s, return the second largest numerical digit that appears in s, or -1 if it does not exist.

An alphanumeric string is a string consisting of lowercase English letters and digits.

 

Example 1:

Input: s = "dfa12321afd"
Output: 2
Explanation: The digits that appear in s are [1, 2, 3]. The second largest digit is 2.
Example 2:

Input: s = "abc1111"
Output: -1
Explanation: The digits that appear in s are [1]. There is no second largest digit. 
 

Constraints:

1 <= s.length <= 500
s consists of only lowercase English letters and/or digits*/

using System;

namespace DSA_ProblemsDa2
{
    class SecondLargestDigitInString
    {
        public static int SecondHighest(string s)
        {
            int largest = -1; // Initialize variable to store the largest digit
            int secondLargest = -1; // Initialize variable to store the second largest digit

            foreach (char c in s) // Iterate through each character in the string
            {
                if (char.IsDigit(c)) // Check if the character is a digit
                {
                    int digit = c - '0'; // Convert character to integer digit

                    if (digit > largest) // Check if current digit is larger than the largest digit found so far
                    {
                        secondLargest = largest; // Update second largest digit
                        largest = digit; // Update largest digit
                    }
                    else if (digit < largest && digit > secondLargest) // Check if current digit is smaller than largest but larger than second largest
                    {
                        secondLargest = digit; // Update second largest digit
                    }
                }
            }

            return secondLargest; // Return the second largest digit found in the string
        }

        static void Main(string[] args)
        {
            string s = "abc2k3h45j"; 

            int secondLargest = SecondLargestDigitInString.SecondHighest(s);

            if (secondLargest != -1)
            {
                Console.WriteLine($"Second largest digit in the string is: {secondLargest}");
            }
            else
            {
                Console.WriteLine("No second largest digit found in the string.");
            }
        }
    }
}


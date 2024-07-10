/*58.Length of Last Word
 
Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal 
substring
 consisting of non-space characters only.

 

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
 

Constraints:

1 <= s.length <= 104
s consists of only English letters and spaces ' '.
There will be at least one word in s.*/

using System;

namespace DSA_ProblemsDa2
{
    internal class LenghtOfLastWord
    {
        public static int LOLW(string s)
        {
            int count = 0; // Initialize count to store the length of the last word

            string x = s.Trim(); // Remove leading and trailing whitespace from the string

            for (int i = 0; i < x.Length; i++) // Loop through each character in the trimmed string
            {
                if (x[i] == ' ') // Check if the current character is a space
                {
                    count = 0; // Reset count if a space is encountered
                }
                else
                {
                    count++; // Increment count for each non-space character
                }
            }
            return count; // Return the length of the last word
        }

        static void Main(string[] args)
        {
            string s = "Hello world";

            Console.WriteLine(LenghtOfLastWord.LOLW(s)); 
        }
    }
}

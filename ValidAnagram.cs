/*242.Valid Anagram

Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false



Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.*/

using System;
using System.Collections.Generic;

namespace DSA_Problems
{
    class Program
    {
        public static bool ValidAnagram(string str1, string str2)
        {
            string s1 = str1.ToLower(); // Convert first string to lowercase
            string s2 = str2.ToLower(); // Convert second string to lowercase
            if (s1.Length != s2.Length) return false; // If lengths are different, they cannot be anagrams

            var s1Count = new Dictionary<char, int>(); // Dictionary to store character counts for first string
            var s2Count = new Dictionary<char, int>(); // Dictionary to store character counts for second string

            foreach (char c in s1) // Count characters in the first string
            {
                if (s1Count.ContainsKey(c)) s1Count[c]++; // Increment count if character already exists
                else s1Count[c] = 1; // Initialize count if character is seen for the first time
            }

            foreach (char c in s2) // Count characters in the second string
            {
                if (s2Count.ContainsKey(c)) s2Count[c]++; // Increment count if character already exists
                else s2Count[c] = 1; // Initialize count if character is seen for the first time
            }

            foreach (var key in s1Count.Keys) // Compare character counts between the two strings
            {
                if ((!s2Count.ContainsKey(key)) || (s1Count[key] != s2Count[key])) // Check if character count matches
                {
                    return false; // Return false if any character count does not match
                }
            }
            return true; // Return true if all character counts match
        }

        static void Main(string[] args)
        {
            string str1 = "Cat";
            string str2 = "tacc";

            if (Program.ValidAnagram(str1, str2) == true)
            {
                Console.WriteLine("Valid Anagram"); 
            }
            else
            {
                Console.WriteLine("Invalid Anagram"); 
            }
        }
    }
}

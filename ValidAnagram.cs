using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems
{
    class Program
    {
        public static bool ValidAnagram(string str1, string str2)
        {
            string s1 = str1.ToLower();
            string s2 = str2.ToLower();
            if (s1.Length != s2.Length) return false;

            var s1Count = new Dictionary<char, int>();
            var s2Count = new Dictionary<char, int>();

            foreach (char c in s1)
            {
                if (s1Count.ContainsKey(c)) s1Count[c]++;
                else s1Count[c] = 1;
            }

            foreach (char c in s2)
            {
                if (s2Count.ContainsKey(c)) s2Count[c]++;
                else s2Count[c] = 1;
            }

            foreach (var key in s1Count.Keys)
            {
                if ((!s2Count.ContainsKey(key)) || (s1Count[key] != s2Count[key]))
                {
                    return false;
                }
            }
            return true;
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

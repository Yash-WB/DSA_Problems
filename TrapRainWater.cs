/*42.Trapping Rain Water
Hard
Topics
Companies
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

 

Example 1:


Input: height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]
Output: 6
Explanation: The above elevation map(black section) is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1].In this case, 6 units of rain water(blue section) are being trapped.
Example 2:

Input: height = [4, 2, 0, 3, 2, 5]
Output: 9



Constraints:

    n == height.length
1 <= n <= 2 * 104
0 <= height[i] <= 105*/

namespace DsaProblems
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }

            int left = 0, right = height.Length - 1;
            int leftMax = height[left], rightMax = height[right];
            int waterTrapped = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    left++;
                    leftMax = Math.Max(leftMax, height[left]);
                    waterTrapped += leftMax - height[left];
                }
                else
                {
                    right--;
                    rightMax = Math.Max(rightMax, height[right]);
                    waterTrapped += rightMax - height[right];
                }
            }

            return waterTrapped;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine(solution.Trap(height1)); 
        }
    }

}
/*using System.Diagnostics.Metrics;

2582.Pass the Pillow

There are n people standing in a line labeled from 1 to n. The first person in the line is holding a pillow initially. Every second, the person holding the pillow passes it to the next person standing in the line. Once the pillow reaches the end of the line, the direction changes, and people continue passing the pillow in the opposite direction.

For example, once the pillow reaches the nth person they pass it to the n - 1th person, then to the n - 2th person and so on.
Given the two positive integers n and time, return the index of the person holding the pillow after time seconds.

Example 1:

Input: n = 4, time = 5
Output: 2
Explanation: People pass the pillow in the following way: 1-> 2-> 3-> 4-> 3-> 2.
After five seconds, the 2nd person is holding the pillow.
Example 2:

Input: n = 3, time = 2
Output: 3
Explanation: People pass the pillow in the following way: 1-> 2-> 3.
After two seconds, the 3rd person is holding the pillow.
 

Constraints:

2 <= n <= 1000
1 <= time <= 1000
*/


using System;

namespace DSA_ProblemsDa2
{
    class PassThePillow
    {
        public static int PassTheP(int n, int time)
        {
            int person = 1; // Start with the first person
            int current_time = 0; // Initialize the current time counter

            for (int i = 1; i <= time; i++) // Loop through each second up to the given time
            {
                person++; // Pass the pillow to the next person
                current_time++; // Increment the current time counter

                if (time == current_time) // Check if the current time matches the given time
                {
                    return person; // Return the current person holding the pillow
                }

                if (person == n) // Check if the pillow has reached the last person
                {
                    // Reverse direction until the first person is reached or the given time is up
                    while (person != 1 && time != current_time)
                    {
                        person--; // Pass the pillow to the previous person
                        current_time++; // Increment the current time counter

                        if (time == current_time) // Check if the current time matches the given time
                        {
                            return person; // Return the current person holding the pillow
                        }
                    }
                }
            }
            return person; // Return the current person holding the pillow if the loop finishes
        }

        static void Main(string[] args)
        {
            int n = 4; // Number of people in the circle
            int time = 5; // Total time to pass the pillow

            Console.WriteLine(PassThePillow.PassTheP(n, time)); // Output the person holding the pillow at the given time
        }
    }
}


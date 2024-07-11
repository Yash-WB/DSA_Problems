/*1518.Water Bottles

There are numBottles water bottles that are initially full of water. You can exchange numExchange empty water bottles from the market with one full water bottle.

The operation of drinking a full water bottle turns it into an empty bottle.

Given the two integers numBottles and numExchange, return the maximum number of water bottles you can drink.

 

Example 1:


Input: numBottles = 9, numExchange = 3
Output: 13
Explanation: You can exchange 3 empty bottles to get 1 full water bottle.
Number of water bottles you can drink: 9 + 3 + 1 = 13.
Example 2:


Input: numBottles = 15, numExchange = 4
Output: 19
Explanation: You can exchange 4 empty bottles to get 1 full water bottle. 
Number of water bottles you can drink: 15 + 3 + 1 = 19.


Constraints:

1 <= numBottles <= 100
2 <= numExchange <= 100*/

namespace DSA_Problems
{
    class WaterBottles
    {
        public static int CountDrunkWaterBottles(int numBottles, int numExchange)
        {
            int totalBottlesDrunk = numBottles;  // Initialize total drunk

            while (numBottles >= numExchange)  // Loop until no exchanges
            {
                int newBottles = numBottles / numExchange;  // Calculate new bottles
                int remainingBottles = numBottles % numExchange;  // Calculate remaining bottles
                totalBottlesDrunk += newBottles;  // Update total drunk
                numBottles = newBottles + remainingBottles;  // Update current bottles
            }

            return totalBottlesDrunk;  // Return total drunk

        }

        public static void Main(string[] args)
        {
            int numBottles = 12;
            int numExchange = 3;

            int result = WaterBottles.CountDrunkWaterBottles(numBottles, numExchange);

            Console.WriteLine(result);  
        }
    }
}
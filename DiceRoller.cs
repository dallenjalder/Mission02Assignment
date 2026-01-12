using System;

namespace Mission02Assignment
{
    public class DiceRoller
    {
        // Random object used to simulate dice rolls
        private Random rand = new Random();

        // Rolls two dice the specified number of times
        // Returns an array where the index represents the dice sum
        public int[] RollDice(int numRolls)
        {
            // Index 2–12 will be used, so size 13 keeps it simple
            int[] counts = new int[13];

            for (int i = 0; i < numRolls; i++)
            {
                // Roll two six-sided dice
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int sum = die1 + die2;

                // Increment count for the rolled sum
                counts[sum]++;
            }

            // Return the results back to Program.cs
            return counts;
        }
    }
}
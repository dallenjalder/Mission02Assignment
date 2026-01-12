
using System;

namespace Mission02Assignment
{
    public class DiceRoller
    {
        private Random rand = new Random();

        public int[] RollDice(int numRolls)
        {
            int[] counts = new int[13];

            for (int i = 0; i < numRolls; i++)
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int sum = die1 + die2;

                counts[sum]++;
            }

            return counts;
        }
    }
}
using System;

namespace Mission02Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            int numRolls = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("How many dice rolls would you like to simulate? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numRolls) && numRolls > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive whole number.");
                }
            }

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numRolls);

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.");
            Console.WriteLine();

            for (int sum = 2; sum <= 12; sum++)
            {
                int count = results[sum];
                double percent = (double)count / numRolls * 100;
                int stars = (int)Math.Round(percent);

                Console.Write($"{sum}: ");
                Console.WriteLine(new string('*', stars));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
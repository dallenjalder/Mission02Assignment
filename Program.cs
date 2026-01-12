using System;

namespace Mission02Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro message
            Console.WriteLine("Welcome to the dice throwing simulator!");

            int numRolls = 0;
            bool validInput = false;

            // Keep asking until the user enters a valid positive number
            while (!validInput)
            {
                Console.Write("How many dice rolls would you like to simulate? ");
                string input = Console.ReadLine() ?? "";

                // TryParse prevents crashes if the user types something invalid
                if (int.TryParse(input, out numRolls) && numRolls > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive whole number.");
                }
            }

            // Create DiceRoller object and run the simulation
            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numRolls);

            // Output header
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.");
            Console.WriteLine();

            // Loop through dice sums (2–12) and print histogram
            for (int sum = 2; sum <= 12; sum++)
            {
                int count = results[sum];

                // Convert count to a percentage of total rolls
                double percent = (double)count / numRolls * 100;

                // Round percentage to determine number of asterisks
                int stars = (int)Math.Round(percent);

                Console.Write($"{sum}: ");
                Console.WriteLine(new string('*', stars));
            }

            // Exit message
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Grade Calculator!");

        bool keepGoing = true;

        while (keepGoing)
        {
            // Prompt for grade
            Console.Write("Please enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();

            // Validate input
            if (double.TryParse(input, out double grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Oops! The grade must be between 0 and 100. Try again.");
                    continue;
                }

                // Determine letter grade
                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"Your grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("That doesn't look like a valid number. Please enter a number between 0 and 100.");
                continue;
            }

            // Ask to continue or exit
            Console.Write("Would you like to enter another grade? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response != "yes" && response != "y")
            {
                keepGoing = false;
                Console.WriteLine("Thanks for using the Grade Calculator. Goodbye!");
            }
        }
    }

    static string GetLetterGrade(double grade)
    {
        if (grade >= 90.0) return "A";
        if (grade >= 80.0) return "B";
        if (grade >= 70.0) return "C";
        if (grade >= 60.0) return "D";
        return "F";
    }
}
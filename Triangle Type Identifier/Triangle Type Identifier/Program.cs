using System;

abstract class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Triangle Type Identifier!");

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nPlease enter the lengths of the three sides of the triangle:");

            double side1 = GetSideLength("Side 1: ");
            double side2 = GetSideLength("Side 2: ");
            double side3 = GetSideLength("Side 3: ");

            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType = GetTriangleType(side1, side2, side3);
                Console.WriteLine($"\nThis is a {triangleType} triangle.");
            }
            else
            {
                Console.WriteLine("\nThe values entered cannot form a valid triangle.");
            }

            Console.Write("\nWould you like to try again? (yes/no): ");
            string? response = Console.ReadLine()?.Trim().ToLower();
            if (response != "yes" && response != "y")
            {
                keepRunning = false;
                Console.WriteLine("Thanks for using the Triangle Type Identifier. Goodbye!");
            }
        }
    }

    static double GetSideLength(string prompt)
    {
        double length;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (double.TryParse(input, out length) && length > 0)
            {
                return length;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Equilateral";
        else if (a == b || b == c || a == c)
            return "Isosceles";
        else
            return "Scalene";
    }
}

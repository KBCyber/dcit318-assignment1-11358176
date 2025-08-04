using System;

namespace TicketPriceCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Ticket Price Calculator ===");

                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Invalid age. Please enter a positive number.");
                    }
                    else
                    {
                        double price;

                        if (age >= 65 || age <= 12)
                        {
                            price = 7.0;
                        }
                        else
                        {
                            price = 10.0;
                        }

                        Console.WriteLine($"Ticket price: GHC{price}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }

                Console.WriteLine("\nDo you want to calculate another ticket price? (Y/N): ");
                string answer = Console.ReadLine().Trim().ToUpper();

                if (answer != "Y")
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting application. Goodbye!");
                }
            }
        }
    }
}
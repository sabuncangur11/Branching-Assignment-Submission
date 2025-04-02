using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Check if package is too heavy
            if (weight > 50)
            {
                // Display error message for heavy packages
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program if package is too heavy
            }

            // Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Check if package dimensions exceed limit
            if (width + height + length > 50)
            {
                // Display error message for large packages
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program if package is too big
            }

            // Calculate shipping quote
            float quote = (height * width * length * weight) / 100;

            // Display the quote to the user as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Wait for user to press a key before closing
            Console.ReadKey();
        }
    }
}
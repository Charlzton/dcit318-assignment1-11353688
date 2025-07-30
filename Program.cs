using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.WriteLine("Enter your age to calculate the movie ticket price.");
            Console.WriteLine("Seniors (65+) and children (12 or younger) get a discounted price.");

            Console.Write("\nEnter age (or 'q' to exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                return;

            if (!int.TryParse(input, out int age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age (non-negative number).");
            }
            else
            {
                decimal ticketPrice = (age <= 12 || age >= 65) ? 7.00m : 10.00m;
                Console.WriteLine($"\nAge: {age}");
                Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
            }

            Console.WriteLine("\nPress any key to try again...");
            Console.ReadKey();
        }
    }
}

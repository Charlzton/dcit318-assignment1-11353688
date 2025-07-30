using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Interactive Calculator Suite ===");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Exit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunGradeCalculator();
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void RunGradeCalculator()
    {
        Console.Clear();
        Console.WriteLine("=== Grade Calculator ===");

        while (true)
        {
            Console.Write("Enter grade (or q to quit): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "q") return;

            if (!double.TryParse(input, out double grade))
            {
                Console.WriteLine("Invalid grade. Try again.");
                continue;
            }

            char gradeLetter = grade >= 90 ? 'A' :
                               grade >= 80 ? 'B' :
                               grade >= 70 ? 'C' :
                               grade >= 60 ? 'D' : 'F';

            Console.WriteLine($"Letter Grade: {gradeLetter}");
            break;
        }
    }
}

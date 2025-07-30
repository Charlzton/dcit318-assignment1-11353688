using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=== Triangle Type Identifier ===");
        Console.WriteLine("Enter the lengths of three sides of a triangle to determine its type.");

        double[] sides = new double[3];
        string[] sideNames = { "first", "second", "third" };

        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                Console.Write($"\nEnter the length of the {sideNames[i]} side (or 'q' to exit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                    return;

                if (!double.TryParse(input, out double side) || side <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    continue;
                }

                sides[i] = side;
                break;
            }
        }

        // Check if it's a valid triangle
        if (sides[0] + sides[1] <= sides[2] ||
            sides[1] + sides[2] <= sides[0] ||
            sides[0] + sides[2] <= sides[1])
        {
            Console.WriteLine("\n❌ These sides cannot form a valid triangle.");
            return;
        }

        string triangleType;
        if (Math.Abs(sides[0] - sides[1]) < 0.0001 && Math.Abs(sides[1] - sides[2]) < 0.0001)
            triangleType = "Equilateral";
        else if (Math.Abs(sides[0] - sides[1]) < 0.0001 ||
                 Math.Abs(sides[1] - sides[2]) < 0.0001 ||
                 Math.Abs(sides[0] - sides[2]) < 0.0001)
            triangleType = "Isosceles";
        else
            triangleType = "Scalene";

        Console.WriteLine($"\n✔️ Triangle Type: {triangleType}");
    }
}

namespace assignment4_1;
class Program
{
    static void Main(string[] args)
    {
        // Question: 1. Write a program to produce a table of numbers from 10 to 1,
        // with their squares and cubes. Again, your table must look professional!

        // Table Header
        Console.WriteLine("Number\tSquare\tCube");
        Console.WriteLine("------\t------\t----");

        // Loop through numbers 10 - 1
        for (int counter = 10; counter >= 1; counter--)
        {
            int square = counter * counter;
            int cube = counter * counter * counter;

            // Print each row
            Console.WriteLine($"{counter}\t{square}\t{cube}");
        }
    }
}
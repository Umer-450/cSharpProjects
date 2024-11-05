namespace assignment4_1_while;
class Program
{
    static void Main(string[] args)
    {
        // Question: 1. Write a program to produce a table of numbers from 10 to 1,
        // with their squares and cubes. Again, your table must look professional!

        // Table Header
        Console.WriteLine("Number\tSquare\tCube");
        Console.WriteLine("------\t------\t----");

        int counter = 10;

        // Loop through numbers 10 - 1
        while (counter >= 1)
        {
            int square = counter * counter;
            int cube = counter * counter * counter;

            // Print each row
            Console.WriteLine($"{counter}\t{square}\t{cube}");
            counter--;
        }
    }
}
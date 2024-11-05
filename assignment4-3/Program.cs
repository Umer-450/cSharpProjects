namespace assignment4_3;
class Program
{
    static void Main(string[] args)
    {
        // Question: 3. Write and run a C# program that calculates and displays
        // the amount of money available in a bank account that initially has
        // $1,000 deposited in it and that earns 8 percent interest a year.
        // Your program should display the amount available at the end of each
        // year for a period of ten years. Use the relationship that the money
        // available at the end of each year equals the amount of money in the
        // account at the start of the year plus .08 times the amount available
        // at the start of the year.

        // Declare variables
        double balance = 1000;
        double interest = 0.08;

        // Table header
        Console.WriteLine("\nYear\tBalance");

        // Loop to display yearly balance
        for (int year = 1; year <= 10; year++)
        {
            // Inner while loop to run once per year (per iteration)
            int counter = 0;
            while (counter < 1)
            {
                balance += balance * interest;
                counter++;
            }
            // Display output
            Console.WriteLine($"{year}\t{balance:C}");
        }
    }
}
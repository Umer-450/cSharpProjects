namespace assignment3_8;
class Program
{
    static void Main()
    {
        // Question: Write a program that prompts a user for an hourly pay rate.
        // If the value entered is less than $5 65 or greater than $49 99,
        // display an error message

        // Prompt user for an hourly pay rate
        Console.WriteLine("This program checks if the hourly pay rate is valid\n");

        Console.WriteLine("Enter your hourly pay rate:");
        double payRate = Convert.ToDouble(Console.ReadLine());

        bool condition = (payRate < 5.65 || payRate > 49.99);

        // Using switch statement to handle the conditions
        switch (condition)
        {
            case false:
                // Invalid pay rate case
                Console.WriteLine("ERROR: The pay rate is invalid. It should be between $5.65 and $49.99.");
                break;

            case true:
                // Valid pay rate case
                Console.WriteLine($"The pay rate of {payRate:C} is valid.");
                break;
        }
    }
}
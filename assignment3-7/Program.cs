namespace assignment3_7;
class Program
{
    static void Main()
    {
        // Question: Write a program that prompts the user for an hourly pay rate.
        // If the value entered is less than $5.65, display an error message

        // Prompt user
        Console.WriteLine("This program calculates the total pay based on the hourly wage\n");

        // Get user input
        Console.WriteLine("Enter your hourly pay rate");
        double payRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the total hours worked per week");
        int hours = Convert.ToInt32(Console.ReadLine());

        // comparison structure + output
        bool condition = (payRate >= 5.65 && hours > 0);

        switch (condition)
        {
            case true:
                // Valid input, calculate weekly earnings
                Console.WriteLine(@$"You are earning {payRate * hours:C} per week.");
                break;
            default:
                // Invalid input, show error message
                Console.WriteLine("ERROR: Invalid input");
                break;
        }
    }
}
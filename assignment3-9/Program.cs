namespace assignment3_9;
class Program
{
    static void Main()
    {
        // Question: Write a program that prompts a user for an hourly pay rate.
        // If the user enters values less than $5.65 or greater than $49 99,
        // prompt the user again. If the user enters an invalid value again,
        // display an appropriate error message. If the user enters a valid value
        // on either the first or second attempt,
        // display the pay rate as well as the weekly rate
        // which calculated as 40 times the hourly rate

        // Constants for hourly pay limits
        const double MinPay = 5.65;
        const double MaxPay = 49.99;
        const int Hours = 40;

        // Prompt user for hourly pay rate
        Console.WriteLine("Enter your hourly pay rate:");
        double payRate = Convert.ToDouble(Console.ReadLine());

        // Determine the condition for switch statement
        bool condition = (payRate > MinPay && payRate < MaxPay);

        // First attempt switch statement
        switch (condition)
        {
            case false:
                // Invalid pay rate case
                Console.WriteLine("ERROR: The pay rate is less than $5.65 or higher than $49.99. Please enter a valid pay rate:");
                payRate = Convert.ToDouble(Console.ReadLine());
                condition = (payRate > MinPay && payRate < MaxPay); // Check again

                // Second attempt switch statement
                switch (condition)
                {
                    case false:
                        Console.WriteLine("ERROR: The pay rate is still less than $5.65. or greater than $49.99");
                        break;
                    case true:
                        Console.WriteLine($"The pay rate of {payRate:C} is valid.");
                        Console.WriteLine($"Your weekly rate is {(payRate * Hours):C}.");
                        break;
                }
                break;
                
            case true:
                // Valid pay rate case
                Console.WriteLine($"The pay rate of {payRate:C} is valid.");
                Console.WriteLine($"Your weekly rate is {(payRate * Hours):C}.");
                break;
        }
    }
}
namespace assignment3_1;
class Program
{
    static void Main()
    {
    // Question: Write a program that prompts the user for a menu choice.

    // Prompt user
    Console.WriteLine("This program will calculate the geometric properties of objects.\n");
        Console.WriteLine(@"Please choose from the following menu options:
    1. Calculate area
    2. Calculate volume
    3. Calculate surface area
    0. Exit the program");

        // Get user input
        int input = Convert.ToInt32(Console.ReadLine());

        // switch + output
        switch (input)
        {
            case 1:
                Console.WriteLine("Calculating area...");
                break;
            case 2:
                Console.WriteLine("Calculating volume...");
                break;
            case 3:
                Console.WriteLine("Calculating surface area...");
                break;
            case 0:
                Console.WriteLine("Exiting the program...");
                break;
            default:
                Console.WriteLine("ERROR: Invalid choice");
                break;
        }

    }
}


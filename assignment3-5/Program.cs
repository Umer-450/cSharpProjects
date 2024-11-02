namespace assignment3_5;
class Program
{
    static void Main()
    {
        // Question: Write a program for a furniture company.
        // Ask the user to choose Pine, Oak or Mahogany.
        // Show the price of a table manufactured with the chosen wood
        // Pine tables cost $100, Oak tables cost $225, and Mahogany tables cost $310.
        // You must use named constants and switch.
        // Also you must be able to accept any variation on the case.
        // E.g. Pine, pine PINE, pinE, Pine … should give $100.

        // Declare constants
        const int CostPine = 100;
        const int CostOak = 225;
        const int CostMahogany = 310;

        // Prompt user
        Console.WriteLine("Welcome to Umer's Wooden Tables Inc.\n");

        // Get user input
        Console.WriteLine(@"Are you looking for Pine, Oak, or Mahogany tables?");
        string input = Convert.ToString(Console.ReadLine().ToLower());

        // switch + output
        switch (input)
        {
            case "pine":
                Console.WriteLine($"Our Pine tables cost {CostPine:C}.");
                break;
            case "oak":
                Console.WriteLine($"Our Oak tables cost {CostOak:C}.");
                break;
            case "mahogany":
                Console.WriteLine($"Our Mahogany tables cost {CostMahogany:C}.");
                break;
            default:
                Console.WriteLine("ERROR: Invalid choice.");
                break;
        }
    }
}
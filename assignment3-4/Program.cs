namespace assignment3_4;
class Program
{
    static void Main()
    {
        // Question: Write a program that prompts the user for a day of the week.
        // The program will display a message based on the table.

        // Declare constants
        const string atHome = "Home";
        const string atWork = "Work";


        // Prompt user
        Console.WriteLine("This program shows you your schedule for a given day.\n");
        Console.WriteLine("Enter a day of the week");
        string dayOfWeek = Convert.ToString(Console.ReadLine().ToLower());

        switch (dayOfWeek)

        {
            case "sunday":
            case "sun":
            case "wednesday":
            case "wed":
                Console.WriteLine(atHome);
                break;
            case "monday":
            case "mon":
            case "tuesday":
            case "tue":
            case "thursday":
            case "thu":
            case "friday":
            case "fri":
            case "saturday":
            case "sat":
                Console.WriteLine(atWork);
                break;
            default:
                Console.WriteLine("ERROR: Invalid entry. Please try again.");
                break;
        } 
    }
}
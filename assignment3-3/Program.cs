namespace assignment3_3;
class Program
{
    static void Main()
    {
        // Question: Write a program that prompts the user for
        // the number of courses and residency status (domestic or international)
        // and calculates tuition cost.
        // You decide how you want the user to enter her/his residency status
        // and prompt accordingly, also you should use named constants for the cost per course

        // Declare constants
        const int DomesticCost = 325;
        const int InternationalCost = 1375;

        // Prompt user
        Console.WriteLine("This program calculates your tuition cost.\n");

        Console.WriteLine(@"What is your residency status?
    Enter 'Domestic' or 'International'");
        string residencyStatus = Convert.ToString(Console.ReadLine().ToLower());

        Console.WriteLine("How many courses are you taking?");
        int numCourses = Convert.ToInt32(Console.ReadLine());

        switch (residencyStatus)
        {
            case "domestic":
                Console.WriteLine($"Total tuition cost: {numCourses * DomesticCost:C}");
                break;
            case "international":
                Console.WriteLine($"Total tuition cost: {numCourses * InternationalCost:C}");
                break;
            default:
                Console.WriteLine("ERROR: Invalid residency status.");
                break;
        }
    }
}
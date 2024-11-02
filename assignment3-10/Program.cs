namespace assignment3_10;
class Program
{
    static void Main()
    {
        // Question: Write a program for a college’s admissions office.
        // The user enters a numeric high school grade point average (for example, 3 2)
        // and an admission test score. Print the message “Accept” if
        // the student meets either of the following requirements:
        // A grade point average of 3.0 or higher and an admission test score of at least 60
        // A grade point average of less than 3.0 and an admission test score of at least 80
        // If the student does not meet either of the qualification criteria, print ‘Reject” 

        // Prompt user for GPA and admission test score
        Console.WriteLine("Enter your high school grade point average (GPA)");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your admission test score:");
        int admissionScore = Convert.ToInt32(Console.ReadLine());

        // Determine the condition for switch statement based on GPA and score
        bool condition = (gpa >= 3.0 && admissionScore >= 60) || (gpa < 3.0 && admissionScore >= 80);

        // Switch statement to handle the conditions
        switch (condition)
        {
            case true:
                Console.WriteLine("Congratulations, you have been accepted!");
                break;
            case false:
                Console.WriteLine("Reject: Does not meet admission criteria.");
                break;
        }
    }
}
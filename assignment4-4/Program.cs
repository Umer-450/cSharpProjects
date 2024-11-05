namespace assignment4_4;
class Program
{
    static void Main(string[] args)
    {
        // Question 4. Write a C program that continuously requests a grade.
        // If the grade is less than 0 or greater than 100,
        // your program should print an appropriate message informing the user
        // that an invalid grade has been entered, else the grade should be added
        // to a total.
        // If the grade is 999, the program should exit the loop and display
        // the sum, number of valid grades and the average of the valid grades
        // entered. (You must NOT display an invalid message)
        // P.S.The value 999 is use to terminate the cycle and should not be used
        // in any of the calculation. You must not display an “Invalid grade"

        Console.WriteLine("Enter grades one by one (Enter '999' to finish):");

        // Declare variables
        int total = 0;
        int count = 0;

        // Processing
        for (int grade = 0; grade != 999;)
        {
            // Prompt user for grade
            Console.WriteLine("Enter a grade:");
            grade = Convert.ToInt32(Console.ReadLine());

            // Stop the loop if user enters 999
            if (grade == 999)
            {
                break;
            }

            // while loop to validate the grade
            while (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade! Please enter a grade from 0 to 100:");
                grade = Convert.ToInt32(Console.ReadLine());
            }

            total += grade;
            count++;

            continue;
        }

        // Calculate the average
        double average = (double)total / count;

        // Display the results
        Console.WriteLine($"\nThe sum of your grades is {total}.");
        Console.WriteLine($"The number of valid grades you entered is {count}.");
        Console.WriteLine($"Your average grade is {average}.");
    }
}
namespace assignment3_2;
class Program
{
    static void Main()
    {
        // Question: Write a program that allows the user to enter two integers and a character
        // If the character is A, add the two integers
        // If it is S, subtract the second integer from the first
        // else multiply the integers
        // Display the results of the arithmetic.

        // Prompt user
        Console.WriteLine("Enter 2 numbers and a character to perform operations\n");

        Console.WriteLine("Enter the first number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(@"Select from the following characters to perform the specified operation:
    A - Addition (Will add the 2 numbers)
    S - Subtraction (Will subtract the 2nd number from the 1st)
    *Enter any other character* - Will multiply the 2 numbers");
        char character = Convert.ToChar(Console.ReadLine().ToUpper());

        // comparison + output
        switch (character)
        {
            case 'A':
                Console.WriteLine("The sum of the 2 numbers is " + (number1 + number2) + ".");
                break;
            case 'S':
                Console.WriteLine("The difference of the 2 numbers is " + (number1 - number2) + ".");
                break;
            default:
                Console.WriteLine("The product of the 2 numbers is " + (number1 * number2) + ".");
                break;
        }
    }
}


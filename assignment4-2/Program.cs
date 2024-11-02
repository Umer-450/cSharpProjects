namespace assignment4_2;
class Program
{
    static void Main(string[] args)
    {
        // Question: 2. Write a program that displays a conversion table
        // from Fahrenheit to Celsius. The program must request the starting
        // Fahrenheit value, the ending Fahrenheit value, and the increment.
        // Thus, instead of the condition checking for a fixed count,
        // the condition checks for the ending Fahrenheit value.
        // Your table must look professional!

        // Prompt user for inputs
        Console.WriteLine("Enter the starting Fahrenheit value");
        int startValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the ending Fahrenheit value");
        int endValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the increment value");
        int increment = Convert.ToInt32(Console.ReadLine());

        // Table header
        Console.WriteLine("\nFahrenheit\tCelsius");
        Console.WriteLine("__________\t_______");

        // Loop
        while (startValue <= endValue){
            double celsius = (startValue - 32) * 5.0 / 9.0;

            Console.WriteLine($"{startValue,10}\t{celsius,7:F2}");

            // Increment initial value for next iteration
            startValue += increment;
        }
    }
}
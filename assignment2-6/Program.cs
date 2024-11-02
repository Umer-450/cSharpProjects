// Umer Sikander - 301451820
// Assignment 2-6

// 6. Write a program to calculate and display the potential difference between the ends of a wire.
// The program will prompt the user for the current flowing and the resistance of the wire.
// Potential difference is the product of the current and the resistance of the wire and may include a fractional part.
// (Again, use the "F" format-specifier for floating point values).


// Prompt user for inputs

Console.WriteLine("Enter the current flowing in the wire.");
double current = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the resistance of the wire.");
double resistance = Convert.ToDouble(Console.ReadLine());

// Processing

double potentialDiff = current * resistance;

// Output

Console.WriteLine($"The potential difference between the ends of the wire is {potentialDiff:F} volts.");

// Umer Sikander - 301451820
// Assignment 2-3

// 3. Write a program to calculate the area of a circle.
// The user will enter the radius of the circle
// and the program will calculate and display the area according to the formula
// (area = 3.14 * radius * radius). You must accept fractions as the input.
// If the user enters 1.2 for the radius then the area will be 4.52.
// (Use the "F" format-specifier for floating point values).

Console.WriteLine("Please enter the radius of the circle");

double radius = Convert.ToDouble(Console.ReadLine());

double area = 3.14 * radius * radius;

Console.WriteLine($"The area of the circle is {area:F2}.");
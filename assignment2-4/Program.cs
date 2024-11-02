// Umer Sikander - 301451820
// Assignment 2-4

// 4. Write a program that prompts the user for a number (that may be a fraction).
// The program reads in the input and print the following:
// the input as a double, the input as an int and finally the input as a char.
// e.g. if the input is 65.790, then the output will be 65.790, 65, and A.

Console.WriteLine("Please enter a number");

// Retrieve initial input

double input = Convert.ToDouble(Console.ReadLine());

// Convert input by casting to int and char (truncates the fractional portion)

int inputInt = (int)(input);
char inputChar = (char)(inputInt);

Console.WriteLine($"Your input as a double is {input}. \nYour input as an integer is {inputInt}. \nYour input as a char is {inputChar}.");

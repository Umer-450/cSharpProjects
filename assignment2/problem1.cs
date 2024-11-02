// Umer Sikander - 301451820
// Assignment 2-1

// 1. Use the Convert.ToChar() method to obtain a char from an input.
// Write a program to prompt the user to enter a single character.
// The program should display a message like “Your response was y”.
// For this question, you must use a variable of type char.

Console.WriteLine("Please enter a single character.");

string input = Console.ReadLine();

char response = Convert.ToChar(input);

Console.WriteLine("Your response was " + response);
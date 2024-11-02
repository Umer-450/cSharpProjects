// Umer Sikander - 301451820
// Assignment 2-2

// 2. Use the Convert.ToBoolean() method to obtain a bool from an input.
// Write a program to ask the user about the validity of a simple statement.
// The program should accept the response then display the statement as well as the response.
// The response should be true or false. For this question, you must use a variable of type bool.
// It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc.

Console.WriteLine("True or False; Ottawa is the Capital City of Canada.");

string input = Console.ReadLine();

bool response = Convert.ToBoolean(input);

Console.WriteLine(response + ", Ottawa is the Capital of Canada.");
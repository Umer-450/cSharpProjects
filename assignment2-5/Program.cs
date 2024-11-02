// Umer Sikander - 301451820
// Assignment 2-5

// 5. Adult ticket cost $3.75 and child ticket cost $2.25.
// Write a program to prompt the user for the amount of adult and child ticket that she needs.
// The program will display a user-friendly message of the number of tickets brought as well as the total cost.
// (Use the "C" format-string for currency).

// Initialize variables

const double ADULT_COST = 3.75;
const double CHILD_COST = 2.25;


// Prompt user for number of tickets

Console.WriteLine("Please enter the number of adult tickets you are buying.");
int adultTickets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the number of child tickets you are buying.");
int childTickets = Convert.ToInt32(Console.ReadLine());

// Process total cost

double totalCost = (adultTickets * ADULT_COST) + (childTickets * CHILD_COST);

// Output

Console.WriteLine($"You are purchasing {adultTickets} adult tickets and {childTickets} child tickets.\nYour total cost is {totalCost:C}.");

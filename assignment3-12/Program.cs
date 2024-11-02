using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace assignment3_12;
class Program
{
    static void Main()
    {
        // Question: a) Write an application for a lawn-mowing service.
        // The lawn-mowing season lasts 20 weeks. The weekly fee for mowing a lot
        // under 400 square feet is $25. The fee for a lot that is 400 square feet
        // or more, but under 600 square feet, is $35 per week.
        // The fee for a lot that is 600 square feet or over is $50 per week.
        // Prompt the user for the length and width of a lawn, and
        // then print the weekly mowing fee, as well as the total fee for the 20-week season

        // Constants for fees
        const int WeeksInSeason = 20;
        const double FeeUnder400 = 25.00;
        const double Fee400To600 = 35.00;
        const double FeeOver600 = 50.00;

        // Prompt user for lawn dimensions
        Console.WriteLine("Enter the length of the lawn in feet");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of the lawn in feet");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate area of the lawn
        double area = length * width;

        // Initialize weekly fee
        double weeklyFee = 0;

        // Determine weekly fee based on area using switch statement
        switch (area)
        {
            case double when area < 400:
                weeklyFee = FeeUnder400;
                break;
            case double when area >= 400 && area < 600:
                weeklyFee = Fee400To600;
                break;
            case double when area >= 600:
                weeklyFee = FeeOver600;
                break;
            default:
                Console.WriteLine("ERROR: Invalid entry.");
                break;
        }

        // Calculate total fee for the season
        double totalFee = weeklyFee * WeeksInSeason;

        // Output the results
        Console.WriteLine($"Weekly Mowing Fee: {weeklyFee:C}");
        Console.WriteLine($"Total Fee for the 20-week season: {totalFee:C}");

        // Question: b) To the Lawn application you created in Exercise 12a, add a prompt
        // that asks the user whether the customer wants to pay(1) once, (2) twice, or(3) 20 times per year.
        // If the user enters 1 for once, the fee for the season is simply the seasonal total.
        // If the customer requests two payments, each payment is half the seasonal fee plus a $5 service charge.
        // If the user requests 20 separate payments,
        // add a $3 service charge per week.Display the number of payments the customer must
        // make, each payment amount, and the total for the season

        const double ServiceChargeTwice = 5.00;
        const double ServiceChargeTwentyTimes = 3.00;

        Console.WriteLine("\nHow would you like to pay?");
        Console.WriteLine("1. Pay once");
        Console.WriteLine("2. Pay twice (service charge applied)");
        Console.WriteLine("3. Pay 20 times (service charge applied)");
        Console.WriteLine("Enter your choice (1, 2, or 3)");
        int paymentOption = Convert.ToInt32(Console.ReadLine());

        // Initialize variables for number of payments and payment amount
        int numberOfPayments = 0;
        double paymentAmount = 0;

        // Use switch statement to handle payment options
        switch (paymentOption)
        {
            case 1:
                numberOfPayments = 1;
                paymentAmount = totalFee;
                break;

            case 2:
                numberOfPayments = 2;
                paymentAmount = (totalFee / 2) + ServiceChargeTwice;
                totalFee += ServiceChargeTwice * numberOfPayments;
                break;

            case 3:
                numberOfPayments = 20;
                paymentAmount = (weeklyFee + ServiceChargeTwentyTimes);
                totalFee += ServiceChargeTwentyTimes * numberOfPayments;
                break;

            default:
                Console.WriteLine("Invalid choice. Please restart the program.");
                break;
        }

        // Output the results
        Console.WriteLine($"\nYou selected to pay {numberOfPayments} time(s).");
        Console.WriteLine($"Each payment will be: {paymentAmount:C}");
        Console.WriteLine($"Total fee for the season: {totalFee:C}");
    }
}
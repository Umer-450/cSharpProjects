namespace assignment3_11;
class Program
{
    static void Main()
    {
        // Question: Write a program that prompts the user for an hourly pay rate
        // and hours worked. Compute gross pay (hours times pay rate),
        // withholding tax, and net pay (gross pay minus withholding tax)
        // Withholding tax is computed as a percentage of gross pay based on the
        // following

        // Prompt user for hourly pay rate and hours worked
        Console.WriteLine("Enter your hourly pay rate:");
        double payRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter total hours worked:");
        int hoursWorked = Convert.ToInt32(Console.ReadLine());

        // Calculate gross pay
        double grossPay = payRate * hoursWorked;

        // Determine withholding tax percentage based on gross pay
        int taxRate;

        // Set tax rate based on gross pay
        switch (grossPay <= 300.00)
        {
            case true:
                taxRate = 10; // 10%
                break;
            case false:
                taxRate = 12; // 12%
                break;
        }

        // Calculate withholding tax and net pay
        double withholdingTax = grossPay * (taxRate / 100.0);
        double netPay = grossPay - withholdingTax;

        // Output the results
        Console.WriteLine($"Gross Pay: {grossPay:C}");
        Console.WriteLine($"Withholding Tax: {withholdingTax:C} ({taxRate}%)");
        Console.WriteLine($"Net Pay: {netPay:C}");
    }
}
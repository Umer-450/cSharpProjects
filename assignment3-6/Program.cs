namespace assignment3_6;
class Program
{
    static void Main(string[] args)
    {
        // Question:Write a program to calculate the roots of a quadratic equation. 

        // Prompt and accept a, b, c
        Console.WriteLine("Enter a value for a");
        double a = Convert.ToDouble(Console.ReadLine());

        switch (a)
        {
            case 0:
                Console.WriteLine("Invalid input for 'a'. 'a' cannot be zero.");
                break;
        }

        Console.WriteLine("Enter the value of b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of c");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calculating the discriminant (b^2 - 4ac)
        double discriminant = (b * b) - (4 * a * c);
        double p = -b / (2 * a);
        double q;

        // Checking discriminant
        switch (discriminant >= 0)
        {
            case true:
                // Real roots
                q = Math.Sqrt(discriminant) / (2 * a);
                Console.WriteLine($"The roots are: {p + q} and {p - q}");
                break;

            case false:
                // Complex roots
                q = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"The roots are: {p} + {q}i and {p} - {q}i");
                break;
        }
    }
}   
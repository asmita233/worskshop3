

public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine("Difference: " + (a - b));
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Product: " + (a * b));
    }

    public void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Quotient: " + ((double)a / b));
        else
            Console.WriteLine("Error: Division by zero is not allowed.");
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Operators op = new Operators();

        op.Add(10, 5);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);
        op.OddEvenFinder(7);
        op.OddEvenFinder(8);
    }
}


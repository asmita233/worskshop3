

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }

        string category = age switch
        {
            < 13 => "Child",
            >= 13 and <= 19 => "Teenager",
            _ => "Adult"
        };

        Console.WriteLine($"(Using switch) You are a {category}.");
    }
}
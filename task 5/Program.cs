using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum from 1 to " + N + " is: " + sum);
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Numbers from 1 to 20 (skipping multiples of 4, stop at 15):");

        int num = 1;
        while (num <= 20)
        {
            if (num % 4 == 0)
            {
                num++;
                continue;
            }

            if (num == 15)
                break;

            Console.Write(num + " ");
            num++;
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");

        int[] numbers = { 2, 4, 6, 8, 10 };
        int total = 0;

        foreach (int n in numbers)
        {
            total += n;
        }

        Console.WriteLine("Sum of array elements: " + total);
    }
}
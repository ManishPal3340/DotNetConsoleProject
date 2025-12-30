using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("How many numbers? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));   // Add()
        }

        Console.WriteLine("\nTotal Elements: " + numbers.Count); // Count

        Console.Write("Enter number to check: ");
        int check = int.Parse(Console.ReadLine());

        if (numbers.Contains(check))   // Contains()
            Console.WriteLine("Number exists");
        else
            Console.WriteLine("Number not found");

        Console.Write("Enter number to remove: ");
        int remove = int.Parse(Console.ReadLine());
        numbers.Remove(remove);        // Remove()

        Console.WriteLine("\nFinal List:");
        foreach (int num in numbers)
            Console.WriteLine(num);
    }
}



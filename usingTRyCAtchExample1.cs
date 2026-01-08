using System;
using System.Collections.Generic;

class usingTRyCAtchExample1
{
    static void Main()
    {
        List<int> list = new List<int>();

        try
        {
            Console.Write("How many numbers? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter index to access: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Value: " + list[index]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only numbers");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid index");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}

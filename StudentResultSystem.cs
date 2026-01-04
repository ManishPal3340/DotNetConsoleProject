using System;
using System.Collections.Generic;

class StudentResultSystem
{
    static void Main()
    {
        List<int> marks = new List<int>();

        try
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter marks: ");
                int m = int.Parse(Console.ReadLine());

                if (m < 0 || m > 100)
                    throw new Exception("Marks must be between 0 and 100");

                marks.Add(m);
            }

            Console.Write("Enter index to view marks: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Marks: " + marks[index]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter only numbers");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid index");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Program executed successfully");
        }
    }
}

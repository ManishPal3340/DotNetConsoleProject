
    using System;

class usingTRyCAtchExample3
{
    static void CheckAge(int age)
    {
        if (age < 18)
            throw new Exception("Age must be 18 or above");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            CheckAge(age);
            Console.WriteLine("Eligible");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

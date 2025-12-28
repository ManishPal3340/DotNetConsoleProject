using System;

class StudentResultSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Student Name ");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Marks :");
        int marks=Convert.ToInt32(Console.ReadLine())   ;

        if (marks >= 40)
        {
            Console.WriteLine(name+ " is PAss");
        }
        else
        {
            Console.WriteLine(name + "is fail");
        }
    }
}

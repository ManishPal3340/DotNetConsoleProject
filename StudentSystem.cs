using System;
using System.IO;

class Studentsystem
{
    static void Main()
    {
        string path = "student.txt";

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        string marks = Console.ReadLine();

        File.AppendAllText(path, $"Name: {name}, Marks: {marks}\n");

        Console.WriteLine("Student data saved");
    }
}

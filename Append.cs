using System;
class Append
{
    public static void Main(string[] args)
    {
        string path = "data.txt";
        File.AppendAllText(path, "\nThis is appended text");
        Console.WriteLine("Text appended successfully");
    }
}
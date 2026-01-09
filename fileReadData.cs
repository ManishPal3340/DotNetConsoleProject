using System;
using System.IO;

class fileReadData
{
    public static void Main(string[] args)
    {
        string path = "data.txt";
        string content=File.ReadAllText(path);
        Console.WriteLine(content); 
    }
}
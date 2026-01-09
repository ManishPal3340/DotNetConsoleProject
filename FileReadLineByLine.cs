using System;
using System.IO;
 
class FileReadLineByLine
{
    public static void Main(string[] args)
    {
        string path = "data.txt";
        string[]lines=File.ReadAllLines(path);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

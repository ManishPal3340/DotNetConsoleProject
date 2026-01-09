using System;
using System.IO;
class firstFileWrite
{
    public   static void Main(string[] args)
    {
        string path = "data.txt";
        File.WriteAllText(path, "Welcome to file Handle Course");
        Console.WriteLine("File created & data written");
    } 
}
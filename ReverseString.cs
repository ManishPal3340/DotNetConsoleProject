using System;
class ReverseString
{
    public static void  Main(string[] args)
    {
        System.Console.WriteLine("Enter The String");
        string input=Console.ReadLine();

        string reverse = "";
        for (int i = input.Length - 1; i > 0; i --)
        {
            reverse=reverse+input[i];
        }
        Console.WriteLine("Reversed String" + reverse);
    }
}
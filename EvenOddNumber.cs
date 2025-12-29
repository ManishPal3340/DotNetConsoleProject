using System;

 class EvenOddNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number");
        int a=Convert.ToInt32(Console.ReadLine())   ;

        if (a %2==0)
        {

            Console.WriteLine("This is Even Number");
        }
        else
        {
            Console.WriteLine("This is Odd Number");
        }
    }
}
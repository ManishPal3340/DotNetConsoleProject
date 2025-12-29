using System;

class Company
{
    public static string CompanyName = "ABC Pvt Ltd";

    public static void Display()
    {
        Console.WriteLine("Company Name: " + CompanyName);
    }
}

class StaticVariable
{
    static void Main()
    {
        Company.Display();
    }
}

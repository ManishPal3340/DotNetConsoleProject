using System;

class InvalidBalanceException : Exception
{
    public InvalidBalanceException(string message) : base(message) { }
}

class usingTRyCAtchExample2
{
    static void Main()
    {
        try
        {
            Console.Write("Enter balance: ");
            int balance = int.Parse(Console.ReadLine());

            if (balance < 1000)
                throw new InvalidBalanceException("Minimum balance should be 1000");

            Console.WriteLine("Balance accepted");
        }
        catch (InvalidBalanceException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

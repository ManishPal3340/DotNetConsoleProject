using System;
using System.Security.Cryptography.X509Certificates;

class BankAccount
{
    private string accHoldName;
   // private string accountName;
   // private string accountType;
    private string accountPassword;
    private string accHoldEmail;
    private string accHoldAddress;
    private double balance;


    public void SetName(string name)
    {
        accHoldName = name; 
    }
    public string GetName()
    {
        return accHoldName;
    }
    public void SetPassword(string password) 
    {
        accountPassword = password;

    }
    public string SetPassword()
    {
        return accountPassword;
    }

    public void SetEmail(string email)
    {
        accHoldEmail = email;

    }
    public string GetEmail()
    {
        return accHoldEmail;
    }

    public void SetAddress(string address)
    {
        accHoldAddress=address;
    }
    public string GetAddress()
    {
        return accHoldAddress;

    }

    public void Deposite(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount Deposite :" + amount);
        }
        else
        {
            Console.WriteLine("Invalid Deposite");
        }
    }

    public void Withdrow(double amount)
    {

        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrow :" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }

        
    }
    public double GetBalance()
    {
        return balance; 
    }

}
class Program
{
    public static void Main(string[] args)

       
    {
        BankAccount ac=new BankAccount();
        ac.SetName("Manish");
        ac.SetPassword("12345");
        ac.SetEmail("manish@gmail.com");
        ac.Deposite(100);
        ac.Withdrow(10);

        Console.WriteLine("Account Holder: " + ac.GetName());
        Console.WriteLine("Current Balance: " + ac.GetBalance());
        Console.WriteLine("Account Password: " + ac.SetPassword());
        Console.WriteLine("holder Email ID: " + ac.GetAddress());
        
    }
}
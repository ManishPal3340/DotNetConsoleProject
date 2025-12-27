using System;

class BankAccount
{
    // ----- Private Data member ( Data hinding)---------------
    private string accountHolderName;
    private string accountType;
    private string accountPassword;
    private string emailId;
    private double balance;

    // ------------setter Mathod use-----------

    public void SetAccountDetails(string name, string tpye, string password, string email)
    {
        accountHolderName = name;
        accountType = tpye;
        accountPassword = password;
        emailId = email;



    }
    // ------ Deposite methods-------------

    public void Deposit(double amount)
    {
        if (amount > 0)

        {
            balance += amount;
            Console.WriteLine("amount Deposite SuceessFully :  " + amount);
        }
        else
        {
            Console.WriteLine("Invalid Deposite Amount");
        }


    }

    // -----------withdrow-----------

    public void Withdraw(double amount, string password)
    {
        if (password != accountPassword)
        {
            Console.WriteLine("Incorrent Password");
            return;
        }
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully: " + amount);
        }
        else
        {
            Console.WriteLine("INficient Balance");
        }

    }

    // check Balance ------------
    public void CheckBalance(String password)
    {
        if (password == accountPassword)
        {
            Console.WriteLine("Current Balance  : " + balance);

        }
        else
        {
            Console.WriteLine("Wrong Password ! connot Show Balance");

        }
    }

    // display  Account Informartion

    public void DisplayAccountInfo()
    {
        Console.WriteLine("\n-------Accnount Details-----------");
        Console.WriteLine("Account holder Name : " + accountHolderName);
        Console.WriteLine("  Account Type : " + accountType);
        Console.WriteLine(" Account ID " + emailId);
        Console.WriteLine();
    }

    class BankManagmentSystem
    {
        public static void Main(string[] args)
        {
            BankAccount ac = new BankAccount();

            // -------User Input --------------

            Console.WriteLine(" Enter Account holder Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Account Type ( Saving/ Current)");
            string type = Console.ReadLine();

            Console.WriteLine("Set Account Password : ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter Email ID : ");
            string email = Console.ReadLine();

            ac.SetAccountDetails(name, type, password, email);

            Console.Write("\n Enter  Deposte Amount ");
            double depAmt = Convert.ToDouble(Console.ReadLine());

            ac.Deposit(depAmt);

            Console.Write("\nEnter Withdraw Amount: ");
            double withAmt = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Password for Withdrow Amount : ");
            string pwd = Console.ReadLine();
            ac.Withdraw(withAmt, pwd);

            Console.Write("\nEnter Password to Check Balance: ");
            string balPwd = Console.ReadLine();
            ac.CheckBalance(balPwd);

            ac.DisplayAccountInfo();
        }
    }
}

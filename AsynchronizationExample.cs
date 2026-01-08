using System;


//Thread-Safe Program (WITH lock ✅)


class BankAccount
{
    public int bal = 1000;
    private object lockObject = new object();


    public void withdrow(int amt)
    {
        lock (lockObject)
        {
            if (bal >= amt)
            {
                Console.WriteLine("Withdrawing " + amt);
                bal -= amt;
                Console.WriteLine("Balance left: " + bal);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }
    class AsynchronizationExample
    {
        public static void Main(string[] args)
        {
            BankAccount acc=new BankAccount();


            Thread t1 = new Thread(() => acc.withdrow(700));
            Thread t2 = new Thread(() => acc.withdrow(700));

            t1.Start();
            t2.Start();


            Console.WriteLine("hello");

            acc.withdrow(100);
        }
    }
}
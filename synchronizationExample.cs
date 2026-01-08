using System;



class BankAccount
{
    public int bal = 1000;
    

    public void withdrow(int amt)
    {
        if(bal >= amt)
        {
            Console.WriteLine("Withrow amount" +amt);
            bal -= amt;
            Console
                .WriteLine("Balance Left" +amt);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
        
    }

}
class synchronizationExample
{
    public static void Main(string[] arg)
    {
        BankAccount ba=new BankAccount();

        Thread t1 = new Thread(()=> ba.withdrow(700));
        t1.Start();
        
        

    }
}
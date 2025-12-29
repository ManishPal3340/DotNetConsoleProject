using System;

class AverageNumber
{
    public static void  Main(string[] args)
    {
        Console.WriteLine("Enter tNE Number");

        int a=Convert.ToInt32(Console.ReadLine())   ;

        int[]marks=new int[a];
        int total=0 ;


        for(int i = 0; i < a; i++)
        {
            Console.WriteLine ("Enter Marks " +(i+1) + " :");
            //marks[i]=Convert.ToInt32 (Console.ReadLine());
            total += marks[i];
        }
        double aver = (double)total / a;
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average: " + aver);


    }
}

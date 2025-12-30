using System;


class CollectionUsingListExample
{
    public static void Main(string[] args)
    {
        List<int> marks = new List<int>();
        Console.Write("how many Marks ?");
        int n=Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            Console.Write("Enter Marks :");
            marks.Add(Convert.ToInt32(Console.ReadLine()));

        }
        Console.WriteLine("Marks:");
        foreach (int m in marks)
        {
            Console.WriteLine(m); 
        }
    }
}



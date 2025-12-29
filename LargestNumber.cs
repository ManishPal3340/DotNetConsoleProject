using System;

class LargestNumber
{
    public static void Main(string[] args)
    {

        int[] arr = { 12, 11, 4, 4, 5, 6, 7, 32, 4, 4, 45,45 };
        int max = arr[0];


        for (int i=1;i<arr.Length;i++)
        {
            if(arr[i] > max)
                max=arr[i];
        }






        Console.WriteLine(" the Largest  Number" + max);
    }
}